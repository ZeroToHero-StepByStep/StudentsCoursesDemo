// <auto-generated />
namespace IC_Assignment.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class AddManyToManyRelationshipBetweenCustomersAndCourses : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(AddManyToManyRelationshipBetweenCustomersAndCourses));
        
        string IMigrationMetadata.Id
        {
            get { return "201708210942188_AddManyToManyRelationshipBetweenCustomersAndCourses"; }
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
