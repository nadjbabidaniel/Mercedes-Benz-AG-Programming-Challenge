using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWEBAPI.Models
{


    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1", IsNullable = false)]
    public partial class Response
    {

        private string copyrightField;

        private string brandLogoUriField;

        private byte statusCodeField;

        private string statusDescriptionField;

        private string authenticationResultCodeField;

        private string traceIdField;

        private ResponseResourceSets resourceSetsField;

        /// <remarks/>
        public string Copyright
        {
            get
            {
                return this.copyrightField;
            }
            set
            {
                this.copyrightField = value;
            }
        }

        /// <remarks/>
        public string BrandLogoUri
        {
            get
            {
                return this.brandLogoUriField;
            }
            set
            {
                this.brandLogoUriField = value;
            }
        }

        /// <remarks/>
        public byte StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public string StatusDescription
        {
            get
            {
                return this.statusDescriptionField;
            }
            set
            {
                this.statusDescriptionField = value;
            }
        }

        /// <remarks/>
        public string AuthenticationResultCode
        {
            get
            {
                return this.authenticationResultCodeField;
            }
            set
            {
                this.authenticationResultCodeField = value;
            }
        }

        /// <remarks/>
        public string TraceId
        {
            get
            {
                return this.traceIdField;
            }
            set
            {
                this.traceIdField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSets ResourceSets
        {
            get
            {
                return this.resourceSetsField;
            }
            set
            {
                this.resourceSetsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSets
    {

        private ResponseResourceSetsResourceSet resourceSetField;

        /// <remarks/>
        public ResponseResourceSetsResourceSet ResourceSet
        {
            get
            {
                return this.resourceSetField;
            }
            set
            {
                this.resourceSetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSet
    {

        private byte estimatedTotalField;

        private ResponseResourceSetsResourceSetResources resourcesField;

        /// <remarks/>
        public byte EstimatedTotal
        {
            get
            {
                return this.estimatedTotalField;
            }
            set
            {
                this.estimatedTotalField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResources Resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResources
    {

        private ResponseResourceSetsResourceSetResourcesLocation locationField;

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocation Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocation
    {

        private string nameField;

        private ResponseResourceSetsResourceSetResourcesLocationPoint pointField;

        private ResponseResourceSetsResourceSetResourcesLocationBoundingBox boundingBoxField;

        private string entityTypeField;

        private ResponseResourceSetsResourceSetResourcesLocationAddress addressField;

        private string confidenceField;

        private string matchCodeField;

        private ResponseResourceSetsResourceSetResourcesLocationGeocodePoint geocodePointField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocationPoint Point
        {
            get
            {
                return this.pointField;
            }
            set
            {
                this.pointField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocationBoundingBox BoundingBox
        {
            get
            {
                return this.boundingBoxField;
            }
            set
            {
                this.boundingBoxField = value;
            }
        }

        /// <remarks/>
        public string EntityType
        {
            get
            {
                return this.entityTypeField;
            }
            set
            {
                this.entityTypeField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocationAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string Confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public string MatchCode
        {
            get
            {
                return this.matchCodeField;
            }
            set
            {
                this.matchCodeField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocationGeocodePoint GeocodePoint
        {
            get
            {
                return this.geocodePointField;
            }
            set
            {
                this.geocodePointField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocationPoint
    {

        private decimal latitudeField;

        private decimal longitudeField;

        /// <remarks/>
        public decimal Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocationBoundingBox
    {

        private decimal southLatitudeField;

        private decimal westLongitudeField;

        private decimal northLatitudeField;

        private decimal eastLongitudeField;

        /// <remarks/>
        public decimal SouthLatitude
        {
            get
            {
                return this.southLatitudeField;
            }
            set
            {
                this.southLatitudeField = value;
            }
        }

        /// <remarks/>
        public decimal WestLongitude
        {
            get
            {
                return this.westLongitudeField;
            }
            set
            {
                this.westLongitudeField = value;
            }
        }

        /// <remarks/>
        public decimal NorthLatitude
        {
            get
            {
                return this.northLatitudeField;
            }
            set
            {
                this.northLatitudeField = value;
            }
        }

        /// <remarks/>
        public decimal EastLongitude
        {
            get
            {
                return this.eastLongitudeField;
            }
            set
            {
                this.eastLongitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocationAddress
    {

        private string addressLineField;

        private string adminDistrictField;

        private string adminDistrict2Field;

        private string countryRegionField;

        private string formattedAddressField;

        private string localityField;

        private uint postalCodeField;

        private ResponseResourceSetsResourceSetResourcesLocationAddressIntersection intersectionField;

        /// <remarks/>
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        public string AdminDistrict
        {
            get
            {
                return this.adminDistrictField;
            }
            set
            {
                this.adminDistrictField = value;
            }
        }

        /// <remarks/>
        public string AdminDistrict2
        {
            get
            {
                return this.adminDistrict2Field;
            }
            set
            {
                this.adminDistrict2Field = value;
            }
        }

        /// <remarks/>
        public string CountryRegion
        {
            get
            {
                return this.countryRegionField;
            }
            set
            {
                this.countryRegionField = value;
            }
        }

        /// <remarks/>
        public string FormattedAddress
        {
            get
            {
                return this.formattedAddressField;
            }
            set
            {
                this.formattedAddressField = value;
            }
        }

        /// <remarks/>
        public string Locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public ResponseResourceSetsResourceSetResourcesLocationAddressIntersection Intersection
        {
            get
            {
                return this.intersectionField;
            }
            set
            {
                this.intersectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocationAddressIntersection
    {

        private string baseStreetField;

        private string secondaryStreet1Field;

        private string secondaryStreet2Field;

        private string intersectionTypeField;

        private string displayNameField;

        /// <remarks/>
        public string BaseStreet
        {
            get
            {
                return this.baseStreetField;
            }
            set
            {
                this.baseStreetField = value;
            }
        }

        /// <remarks/>
        public string SecondaryStreet1
        {
            get
            {
                return this.secondaryStreet1Field;
            }
            set
            {
                this.secondaryStreet1Field = value;
            }
        }

        /// <remarks/>
        public string SecondaryStreet2
        {
            get
            {
                return this.secondaryStreet2Field;
            }
            set
            {
                this.secondaryStreet2Field = value;
            }
        }

        /// <remarks/>
        public string IntersectionType
        {
            get
            {
                return this.intersectionTypeField;
            }
            set
            {
                this.intersectionTypeField = value;
            }
        }

        /// <remarks/>
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/search/local/ws/rest/v1")]
    public partial class ResponseResourceSetsResourceSetResourcesLocationGeocodePoint
    {

        private decimal latitudeField;

        private decimal longitudeField;

        private string calculationMethodField;

        private string usageTypeField;

        /// <remarks/>
        public decimal Latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal Longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }

        /// <remarks/>
        public string CalculationMethod
        {
            get
            {
                return this.calculationMethodField;
            }
            set
            {
                this.calculationMethodField = value;
            }
        }

        /// <remarks/>
        public string UsageType
        {
            get
            {
                return this.usageTypeField;
            }
            set
            {
                this.usageTypeField = value;
            }
        }
    }



}