
namespace ConsumerApp
{
    internal struct StructType
    {




        internal void Execute()
        {
            Test t = new Test
            {
                Id = 1,
                Name = "123"
            };


            //t.Dump();
        }

    }


    struct Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
