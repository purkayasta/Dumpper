

using Dumpper.Types.Generics;

namespace ConsumerApp
{
    internal class ClassTypes
    {
        internal void Execute()
        {
            var m = new Model() { Name = "Sunny", Id = 12, Email = "Pri", CreatedOn = DateTime.Now, ModifiedOn = DateTime.UtcNow };
            List<Model> models = new List<Model>()
            {
                new Model() { Name = "Pritom", CreatedOn = DateTime.Now },
                new Model() { Name = "Purkayasta", CreatedOn= DateTime.Now, Email= "Orit@gm" },
                m
            };



            m.Dump();
            models.Dump();
        }
    }

    internal class Model : Base, IModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Get()
        {
            Console.WriteLine("asdasd");
        }
    }

    internal class Base
    {
        public DateTime ModifiedOn { get; set; } = new DateTime();
    }

    internal interface IModel
    {

        public void Get();
    }
}
