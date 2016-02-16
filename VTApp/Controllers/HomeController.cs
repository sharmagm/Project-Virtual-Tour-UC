using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI;

namespace VTApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Create your Virtual Tour.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetSiteConfigData(int buildingIDVal)
        {            
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;

            ServiceReference1.VirtualTourClient client = new ServiceReference1.VirtualTourClient();
            var b = client.GetBuildingByID(buildingIDVal);
            jsonData = SetImagesAndArrows(b.Image_ID);
            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ActionResult GetLinks()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;
            string l3 = "javascript:void(0);";

            ServiceReference1.VirtualTourClient vt = new ServiceReference1.VirtualTourClient();
            var buildings = vt.CreateList();
            string l2 = string.Empty;
            foreach (var b in buildings)
            {
                l2 = l2 + "<li><a onclick=" + "\"setMainImage(" + b.Building_ID + ");\"" + "href=" +  "\"javascript:void(0);\"" + ">" + b.Building_name + "</a></li>";
            }

            jsonData = new
            {
                testId = l2
            };
            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ActionResult ReplaceFwdImage(int imageIDVal)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;
            int arrowF = 1;
            int arrowB = 1;
            int arrowR = 1;
            int arrowL = 1;

            ServiceReference1.VirtualTourClient client = new ServiceReference1.VirtualTourClient();
            var a = client.GetImagesForDirections(imageIDVal);
            var i = client.GetImageByID(a.Image_front);
            string base64String = Convert.ToBase64String(i.Image_code);
            var f = client.GetImagesForDirections(a.Image_front);

            if (f.Image_front == 0)
                arrowF = 0;

            if (f.Image_back == 0)
                arrowB = 0;

            if (f.Image_left == 0)
                arrowL = 0;

            if (f.Image_right == 0)
                arrowR = 0;

            jsonData = new
            {
                testId = base64String,
                imageID = a.Image_front,
                showArrowRight = arrowR,
                showArrowLeft = arrowL,
                showArrowFwd = arrowF,
                showArrowBwd = arrowB
            };

            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ActionResult ReplaceBwdImage(int imageIDVal)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;
            
            var a = GetImagesByDirection(imageIDVal);
            jsonData = SetImagesAndArrows(a.Image_back);

            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ActionResult ReplaceLeftImage(int imageIDVal)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;

            var a = GetImagesByDirection(imageIDVal);
            int id = a.Image_left.Value;
            jsonData = SetImagesAndArrows(id);

            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ActionResult ReplaceRightImage(int imageIDVal)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;

            var a = GetImagesByDirection(imageIDVal);
            int id = a.Image_right.Value;
            jsonData = SetImagesAndArrows(id);

            return Content(serializer.Serialize(jsonData), "application/json");
        }

        public ServiceReference1.Image_direction GetImagesByDirection(int imageID)
        {
            ServiceReference1.VirtualTourClient client = new ServiceReference1.VirtualTourClient();
            var a = client.GetImagesForDirections(imageID);
            return a;
        }

        public object SetImagesAndArrows(int imageID)
        {
            object jsonData = null;
            int arrowF = 1;
            int arrowB = 1;
            int arrowR = 1;
            int arrowL = 1;

            ServiceReference1.VirtualTourClient client = new ServiceReference1.VirtualTourClient();
            var i = client.GetImageByID(imageID);
            string base64String = Convert.ToBase64String(i.Image_code);
            var b = GetImagesByDirection(imageID);

            if (b.Image_front == 0)
                arrowF = 0;

            if (b.Image_back == 0)
                arrowB = 0;

            if (b.Image_left == 0)
                arrowL = 0;

            if (b.Image_right == 0)
                arrowR = 0;

            jsonData = new
            {
                testId = base64String,
                imageID = imageID,
                showArrowRight = arrowR,
                showArrowLeft = arrowL,
                showArrowFwd = arrowF,
                showArrowBwd = arrowB
            };

            return jsonData;
        }

        public void SaveBuildingDetails(string buildingIDVal, string buildingDescVal)
        {
            ServiceReference1.VirtualTourClient vt = new ServiceReference1.VirtualTourClient();
            vt.SaveBuildingInfo(buildingIDVal, buildingDescVal);
        }

        public ActionResult  SaveImageDetails(string imagPathVal, string direction)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            object jsonData = null;
            
            ServiceReference1.VirtualTourClient vt = new ServiceReference1.VirtualTourClient();

            Image img = Image.FromFile(imagPathVal);
            byte[] imgByte = imageToByteConverter(img);
            string base64String = Convert.ToBase64String(imgByte);
            int imgId = vt.SaveImageInfor(base64String, direction);
            vt.SaveImageDirectionData(imgId, direction);

            jsonData = new
            {
                directValue = direction,
                imageIDValue = imgId
            };

            return Content(serializer.Serialize(jsonData), "application/json");    
        }

        public static byte[] imageToByteConverter(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
    }
}