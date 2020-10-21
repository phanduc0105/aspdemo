namespace aspdemo
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class aspDemoModel : DbContext
    {
        public aspDemoModel()
            : base("name=aspDemo_Model")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
