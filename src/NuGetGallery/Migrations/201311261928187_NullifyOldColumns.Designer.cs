// <auto-generated />
namespace NuGetGallery.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    public sealed partial class NullifyOldColumns : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(NullifyOldColumns));
        
        string IMigrationMetadata.Id
        {
            get { return "201311261928187_NullifyOldColumns"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
