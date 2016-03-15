using System;


namespace NExifTool
{
    public class TagGroup
    {
        public string GeneralGroup { get; set; }
        public string SpecificGroup { get; set; }
        public string CategoryGroup { get; set; }
        public string DocumentNumberGroup { get; set; }
        public string InstanceNumberGroup { get; set; }
        
         
        public bool IsGps
        {
            get
            {
                return !string.IsNullOrEmpty(SpecificGroup) && SpecificGroup.StartsWith("GPS", StringComparison.OrdinalIgnoreCase);
            }
        }
        
        
        public bool IsNikon
        {
            get
            {
                return !string.IsNullOrEmpty(SpecificGroup) && SpecificGroup.StartsWith("Nikon", StringComparison.OrdinalIgnoreCase); 
            }
        }
        
        
        public bool IsExif
        {
            get
            {
                return !string.IsNullOrEmpty(GeneralGroup) && GeneralGroup.Equals("EXIF", StringComparison.OrdinalIgnoreCase);
            }
        }
        
        
        internal string LookupPrefix
        {
            get
            {
                return $"{GeneralGroup}:{SpecificGroup}:{CategoryGroup}::".ToLower();
            }
        }
    }
}
