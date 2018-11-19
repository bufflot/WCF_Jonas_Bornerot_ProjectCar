﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWebClient.WcfServiceCarHost {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Car : HelloWebClient.WcfServiceCarHost.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AvaliableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HelloWebClient.WcfServiceCarHost.Booking[] BookingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegistrationNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> YearField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Avaliable {
            get {
                return this.AvaliableField;
            }
            set {
                if ((this.AvaliableField.Equals(value) != true)) {
                    this.AvaliableField = value;
                    this.RaisePropertyChanged("Avaliable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HelloWebClient.WcfServiceCarHost.Booking[] Bookings {
            get {
                return this.BookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingsField, value) != true)) {
                    this.BookingsField = value;
                    this.RaisePropertyChanged("Bookings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegistrationNumber {
            get {
                return this.RegistrationNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.RegistrationNumberField, value) != true)) {
                    this.RegistrationNumberField = value;
                    this.RaisePropertyChanged("RegistrationNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HelloWebClient.WcfServiceCarHost.Booking))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HelloWebClient.WcfServiceCarHost.Customer))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(HelloWebClient.WcfServiceCarHost.Car))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedOnUtcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
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
        public System.DateTime CreatedOnUtc {
            get {
                return this.CreatedOnUtcField;
            }
            set {
                if ((this.CreatedOnUtcField.Equals(value) != true)) {
                    this.CreatedOnUtcField = value;
                    this.RaisePropertyChanged("CreatedOnUtc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Booking", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Booking : HelloWebClient.WcfServiceCarHost.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HelloWebClient.WcfServiceCarHost.Car CarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CarIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HelloWebClient.WcfServiceCarHost.Customer CustomerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HelloWebClient.WcfServiceCarHost.Car Car {
            get {
                return this.CarField;
            }
            set {
                if ((object.ReferenceEquals(this.CarField, value) != true)) {
                    this.CarField = value;
                    this.RaisePropertyChanged("Car");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarID {
            get {
                return this.CarIDField;
            }
            set {
                if ((this.CarIDField.Equals(value) != true)) {
                    this.CarIDField = value;
                    this.RaisePropertyChanged("CarID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HelloWebClient.WcfServiceCarHost.Customer Customer {
            get {
                return this.CustomerField;
            }
            set {
                if ((object.ReferenceEquals(this.CustomerField, value) != true)) {
                    this.CustomerField = value;
                    this.RaisePropertyChanged("Customer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerID {
            get {
                return this.CustomerIDField;
            }
            set {
                if ((this.CustomerIDField.Equals(value) != true)) {
                    this.CustomerIDField = value;
                    this.RaisePropertyChanged("CustomerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndTime {
            get {
                return this.EndTimeField;
            }
            set {
                if ((this.EndTimeField.Equals(value) != true)) {
                    this.EndTimeField = value;
                    this.RaisePropertyChanged("EndTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartTime {
            get {
                return this.StartTimeField;
            }
            set {
                if ((this.StartTimeField.Equals(value) != true)) {
                    this.StartTimeField = value;
                    this.RaisePropertyChanged("StartTime");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/Domain")]
    [System.SerializableAttribute()]
    public partial class Customer : HelloWebClient.WcfServiceCarHost.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HelloWebClient.WcfServiceCarHost.Booking[] BookingsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TelField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HelloWebClient.WcfServiceCarHost.Booking[] Bookings {
            get {
                return this.BookingsField;
            }
            set {
                if ((object.ReferenceEquals(this.BookingsField, value) != true)) {
                    this.BookingsField = value;
                    this.RaisePropertyChanged("Bookings");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Tel {
            get {
                return this.TelField;
            }
            set {
                if ((this.TelField.Equals(value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceCarHost.IServiceCar")]
    public interface IServiceCar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/AddCar", ReplyAction="http://tempuri.org/IServiceCar/AddCarResponse")]
        void AddCar(string registrationNumber, string brand, string model, System.Nullable<int> year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/AddCar", ReplyAction="http://tempuri.org/IServiceCar/AddCarResponse")]
        System.Threading.Tasks.Task AddCarAsync(string registrationNumber, string brand, string model, System.Nullable<int> year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/GetCarList", ReplyAction="http://tempuri.org/IServiceCar/GetCarListResponse")]
        HelloWebClient.WcfServiceCarHost.Car[] GetCarList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/GetCarList", ReplyAction="http://tempuri.org/IServiceCar/GetCarListResponse")]
        System.Threading.Tasks.Task<HelloWebClient.WcfServiceCarHost.Car[]> GetCarListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/GetCarByRegNr", ReplyAction="http://tempuri.org/IServiceCar/GetCarByRegNrResponse")]
        HelloWebClient.WcfServiceCarHost.Car GetCarByRegNr(string reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/GetCarByRegNr", ReplyAction="http://tempuri.org/IServiceCar/GetCarByRegNrResponse")]
        System.Threading.Tasks.Task<HelloWebClient.WcfServiceCarHost.Car> GetCarByRegNrAsync(string reg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/DeleteCar", ReplyAction="http://tempuri.org/IServiceCar/DeleteCarResponse")]
        void DeleteCar(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/DeleteCar", ReplyAction="http://tempuri.org/IServiceCar/DeleteCarResponse")]
        System.Threading.Tasks.Task DeleteCarAsync(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/ReturnCar", ReplyAction="http://tempuri.org/IServiceCar/ReturnCarResponse")]
        void ReturnCar(string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCar/ReturnCar", ReplyAction="http://tempuri.org/IServiceCar/ReturnCarResponse")]
        System.Threading.Tasks.Task ReturnCarAsync(string carId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCarChannel : HelloWebClient.WcfServiceCarHost.IServiceCar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCarClient : System.ServiceModel.ClientBase<HelloWebClient.WcfServiceCarHost.IServiceCar>, HelloWebClient.WcfServiceCarHost.IServiceCar {
        
        public ServiceCarClient() {
        }
        
        public ServiceCarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCar(string registrationNumber, string brand, string model, System.Nullable<int> year) {
            base.Channel.AddCar(registrationNumber, brand, model, year);
        }
        
        public System.Threading.Tasks.Task AddCarAsync(string registrationNumber, string brand, string model, System.Nullable<int> year) {
            return base.Channel.AddCarAsync(registrationNumber, brand, model, year);
        }
        
        public HelloWebClient.WcfServiceCarHost.Car[] GetCarList() {
            return base.Channel.GetCarList();
        }
        
        public System.Threading.Tasks.Task<HelloWebClient.WcfServiceCarHost.Car[]> GetCarListAsync() {
            return base.Channel.GetCarListAsync();
        }
        
        public HelloWebClient.WcfServiceCarHost.Car GetCarByRegNr(string reg) {
            return base.Channel.GetCarByRegNr(reg);
        }
        
        public System.Threading.Tasks.Task<HelloWebClient.WcfServiceCarHost.Car> GetCarByRegNrAsync(string reg) {
            return base.Channel.GetCarByRegNrAsync(reg);
        }
        
        public void DeleteCar(string carId) {
            base.Channel.DeleteCar(carId);
        }
        
        public System.Threading.Tasks.Task DeleteCarAsync(string carId) {
            return base.Channel.DeleteCarAsync(carId);
        }
        
        public void ReturnCar(string carId) {
            base.Channel.ReturnCar(carId);
        }
        
        public System.Threading.Tasks.Task ReturnCarAsync(string carId) {
            return base.Channel.ReturnCarAsync(carId);
        }
    }
}