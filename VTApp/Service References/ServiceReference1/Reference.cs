﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VTApp.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Building", Namespace="http://schemas.datacontract.org/2004/07/VirtualTourService")]
    [System.SerializableAttribute()]
    public partial class Building : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Building_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Building_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Building_textField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Image_IDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Building_ID {
            get {
                return this.Building_IDField;
            }
            set {
                if ((this.Building_IDField.Equals(value) != true)) {
                    this.Building_IDField = value;
                    this.RaisePropertyChanged("Building_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Building_name {
            get {
                return this.Building_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Building_nameField, value) != true)) {
                    this.Building_nameField = value;
                    this.RaisePropertyChanged("Building_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Building_text {
            get {
                return this.Building_textField;
            }
            set {
                if ((object.ReferenceEquals(this.Building_textField, value) != true)) {
                    this.Building_textField = value;
                    this.RaisePropertyChanged("Building_text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image_ID {
            get {
                return this.Image_IDField;
            }
            set {
                if ((this.Image_IDField.Equals(value) != true)) {
                    this.Image_IDField = value;
                    this.RaisePropertyChanged("Image_ID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Building_Image", Namespace="http://schemas.datacontract.org/2004/07/VirtualTourService")]
    [System.SerializableAttribute()]
    public partial class Building_Image : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Building_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Image_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] Image_codeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Building_ID {
            get {
                return this.Building_IDField;
            }
            set {
                if ((this.Building_IDField.Equals(value) != true)) {
                    this.Building_IDField = value;
                    this.RaisePropertyChanged("Building_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image_ID {
            get {
                return this.Image_IDField;
            }
            set {
                if ((this.Image_IDField.Equals(value) != true)) {
                    this.Image_IDField = value;
                    this.RaisePropertyChanged("Image_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image_code {
            get {
                return this.Image_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Image_codeField, value) != true)) {
                    this.Image_codeField = value;
                    this.RaisePropertyChanged("Image_code");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Image_direction", Namespace="http://schemas.datacontract.org/2004/07/VirtualTourService")]
    [System.SerializableAttribute()]
    public partial class Image_direction : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Image_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Image_backField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Image_frontField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Image_leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Image_rightField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image_ID {
            get {
                return this.Image_IDField;
            }
            set {
                if ((this.Image_IDField.Equals(value) != true)) {
                    this.Image_IDField = value;
                    this.RaisePropertyChanged("Image_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image_back {
            get {
                return this.Image_backField;
            }
            set {
                if ((this.Image_backField.Equals(value) != true)) {
                    this.Image_backField = value;
                    this.RaisePropertyChanged("Image_back");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Image_front {
            get {
                return this.Image_frontField;
            }
            set {
                if ((this.Image_frontField.Equals(value) != true)) {
                    this.Image_frontField = value;
                    this.RaisePropertyChanged("Image_front");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Image_left {
            get {
                return this.Image_leftField;
            }
            set {
                if ((this.Image_leftField.Equals(value) != true)) {
                    this.Image_leftField = value;
                    this.RaisePropertyChanged("Image_left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Image_right {
            get {
                return this.Image_rightField;
            }
            set {
                if ((this.Image_rightField.Equals(value) != true)) {
                    this.Image_rightField = value;
                    this.RaisePropertyChanged("Image_right");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IVirtualTour")]
    public interface IVirtualTour {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetBuildingByID", ReplyAction="http://tempuri.org/IVirtualTour/GetBuildingByIDResponse")]
        VTApp.ServiceReference1.Building GetBuildingByID(int buildingID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetBuildingByID", ReplyAction="http://tempuri.org/IVirtualTour/GetBuildingByIDResponse")]
        System.Threading.Tasks.Task<VTApp.ServiceReference1.Building> GetBuildingByIDAsync(int buildingID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetImageByID", ReplyAction="http://tempuri.org/IVirtualTour/GetImageByIDResponse")]
        VTApp.ServiceReference1.Building_Image GetImageByID(int imageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetImageByID", ReplyAction="http://tempuri.org/IVirtualTour/GetImageByIDResponse")]
        System.Threading.Tasks.Task<VTApp.ServiceReference1.Building_Image> GetImageByIDAsync(int imageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetImagesForDirections", ReplyAction="http://tempuri.org/IVirtualTour/GetImagesForDirectionsResponse")]
        VTApp.ServiceReference1.Image_direction GetImagesForDirections(int imageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/GetImagesForDirections", ReplyAction="http://tempuri.org/IVirtualTour/GetImagesForDirectionsResponse")]
        System.Threading.Tasks.Task<VTApp.ServiceReference1.Image_direction> GetImagesForDirectionsAsync(int imageID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/checkCredentials", ReplyAction="http://tempuri.org/IVirtualTour/checkCredentialsResponse")]
        bool checkCredentials(string loginID, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/checkCredentials", ReplyAction="http://tempuri.org/IVirtualTour/checkCredentialsResponse")]
        System.Threading.Tasks.Task<bool> checkCredentialsAsync(string loginID, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveCredentials", ReplyAction="http://tempuri.org/IVirtualTour/SaveCredentialsResponse")]
        void SaveCredentials(string loginID, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveCredentials", ReplyAction="http://tempuri.org/IVirtualTour/SaveCredentialsResponse")]
        System.Threading.Tasks.Task SaveCredentialsAsync(string loginID, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveBuildingInfo", ReplyAction="http://tempuri.org/IVirtualTour/SaveBuildingInfoResponse")]
        void SaveBuildingInfo(string buildingIDVal, string buildingDescVal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveBuildingInfo", ReplyAction="http://tempuri.org/IVirtualTour/SaveBuildingInfoResponse")]
        System.Threading.Tasks.Task SaveBuildingInfoAsync(string buildingIDVal, string buildingDescVal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveImageInfor", ReplyAction="http://tempuri.org/IVirtualTour/SaveImageInforResponse")]
        int SaveImageInfor(string imagVal, string direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveImageInfor", ReplyAction="http://tempuri.org/IVirtualTour/SaveImageInforResponse")]
        System.Threading.Tasks.Task<int> SaveImageInforAsync(string imagVal, string direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveImageDirectionData", ReplyAction="http://tempuri.org/IVirtualTour/SaveImageDirectionDataResponse")]
        void SaveImageDirectionData(int imageID, string direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/SaveImageDirectionData", ReplyAction="http://tempuri.org/IVirtualTour/SaveImageDirectionDataResponse")]
        System.Threading.Tasks.Task SaveImageDirectionDataAsync(int imageID, string direction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/CreateList", ReplyAction="http://tempuri.org/IVirtualTour/CreateListResponse")]
        VTApp.ServiceReference1.Building[] CreateList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVirtualTour/CreateList", ReplyAction="http://tempuri.org/IVirtualTour/CreateListResponse")]
        System.Threading.Tasks.Task<VTApp.ServiceReference1.Building[]> CreateListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVirtualTourChannel : VTApp.ServiceReference1.IVirtualTour, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VirtualTourClient : System.ServiceModel.ClientBase<VTApp.ServiceReference1.IVirtualTour>, VTApp.ServiceReference1.IVirtualTour {
        
        public VirtualTourClient() {
        }
        
        public VirtualTourClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VirtualTourClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VirtualTourClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VirtualTourClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VTApp.ServiceReference1.Building GetBuildingByID(int buildingID) {
            return base.Channel.GetBuildingByID(buildingID);
        }
        
        public System.Threading.Tasks.Task<VTApp.ServiceReference1.Building> GetBuildingByIDAsync(int buildingID) {
            return base.Channel.GetBuildingByIDAsync(buildingID);
        }
        
        public VTApp.ServiceReference1.Building_Image GetImageByID(int imageID) {
            return base.Channel.GetImageByID(imageID);
        }
        
        public System.Threading.Tasks.Task<VTApp.ServiceReference1.Building_Image> GetImageByIDAsync(int imageID) {
            return base.Channel.GetImageByIDAsync(imageID);
        }
        
        public VTApp.ServiceReference1.Image_direction GetImagesForDirections(int imageID) {
            return base.Channel.GetImagesForDirections(imageID);
        }
        
        public System.Threading.Tasks.Task<VTApp.ServiceReference1.Image_direction> GetImagesForDirectionsAsync(int imageID) {
            return base.Channel.GetImagesForDirectionsAsync(imageID);
        }
        
        public bool checkCredentials(string loginID, string password) {
            return base.Channel.checkCredentials(loginID, password);
        }
        
        public System.Threading.Tasks.Task<bool> checkCredentialsAsync(string loginID, string password) {
            return base.Channel.checkCredentialsAsync(loginID, password);
        }
        
        public void SaveCredentials(string loginID, string password) {
            base.Channel.SaveCredentials(loginID, password);
        }
        
        public System.Threading.Tasks.Task SaveCredentialsAsync(string loginID, string password) {
            return base.Channel.SaveCredentialsAsync(loginID, password);
        }
        
        public void SaveBuildingInfo(string buildingIDVal, string buildingDescVal) {
            base.Channel.SaveBuildingInfo(buildingIDVal, buildingDescVal);
        }
        
        public System.Threading.Tasks.Task SaveBuildingInfoAsync(string buildingIDVal, string buildingDescVal) {
            return base.Channel.SaveBuildingInfoAsync(buildingIDVal, buildingDescVal);
        }
        
        public int SaveImageInfor(string imagVal, string direction) {
            return base.Channel.SaveImageInfor(imagVal, direction);
        }
        
        public System.Threading.Tasks.Task<int> SaveImageInforAsync(string imagVal, string direction) {
            return base.Channel.SaveImageInforAsync(imagVal, direction);
        }
        
        public void SaveImageDirectionData(int imageID, string direction) {
            base.Channel.SaveImageDirectionData(imageID, direction);
        }
        
        public System.Threading.Tasks.Task SaveImageDirectionDataAsync(int imageID, string direction) {
            return base.Channel.SaveImageDirectionDataAsync(imageID, direction);
        }
        
        public VTApp.ServiceReference1.Building[] CreateList() {
            return base.Channel.CreateList();
        }
        
        public System.Threading.Tasks.Task<VTApp.ServiceReference1.Building[]> CreateListAsync() {
            return base.Channel.CreateListAsync();
        }
    }
}