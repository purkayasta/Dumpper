
using System.Collections.Generic;
using Dumpper;

namespace ConsumerApp;

internal struct StructType
{
    internal void Execute()
    {
        Test t = new Test
        {
            Id = 1,
            Name = "123"
        };

        

        t.Dump();
        
        List<Test> tests = new List<Test>
        {
            new Test()
            {
                Id = 123,
                Name = "Pritom"
            },
            new Test()
            {
                Id = 234,
                Name = "Purkayasta"
            }
        };
        
        tests.Dump();

    }

}


struct Test
{
    public int Id { get; set; }
    public string Name { get; set; }
}