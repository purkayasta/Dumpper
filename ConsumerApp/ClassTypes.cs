

using Dumpper.Types.Collections;

namespace ConsumerApp
{
    internal class ClassTypes
    {
        internal void Execute()
        {
            var model = new List<Model>();
            model.Add(new Model
            {
                Name = "123"
            });
            model.Add(new Model
            {
                Name = "321"
            });
            model.Add(new Model
            {
                Name = "Kazi"
            });

            Model model2 = new Model();
            model2.Dump();

            model.Dump();

            //var model2 = new List<string>();
            //model2.Add("123");
            //model2.Add("312");
            //model2.Add("432");
            //model2.Dump();
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
