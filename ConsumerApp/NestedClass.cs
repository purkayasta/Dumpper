using System.Collections.Generic;
using Dumpper;

namespace ConsumerApp
{
    internal class NestedClass
    {
        public NestedClass()
        {
            var grandParent = new GrandParent(new Parent(1, new Child1(1, nameof(Child1)), new Child2(1, nameof(Child2)), new Child3(1, nameof(Child3))), new Child3(2, "New Child 3 from grand parents"));
            grandParent.Dump();

            var orphanGrandParent = new OrphanGrandParent
            {
                OrphanParent = new OrphanParent
                {
                    OrphanChild = new OrphanChild
                    {
                        Id = 1,
                        OrphanGrandChildren = new List<OrphanGrandChild?>
                        {
                            new OrphanGrandChild { Id = 1},
                            new OrphanGrandChild { Id = 2}
                        }
                    },
                }
            };

            orphanGrandParent.OrphanParent.Dump();

            Console.WriteLine();

            orphanGrandParent.OrphanParent.OrphanChild.Dump();

            Console.WriteLine();

            orphanGrandParent.OrphanParent.OrphanChild.OrphanGrandChildren.Dump();
            Console.WriteLine();
        }
    }

    record Child2(int Id, string Name);
    record Child3(int Id, string Name);
    record Child1(int Id, string Name);
    record Parent(int Id, Child1 Child1, Child2 Child2, Child3 Child3);
    record GrandParent(Parent Parent, Child3 Child3);



    class OrphanChild
    {
        public int Id { get; set; }
        public List<OrphanGrandChild?> OrphanGrandChildren { get; set; }
    }
    class OrphanGrandChild
    {
        public int Id { get; set; }
    }

    class OrphanParent
    {
        public OrphanChild? OrphanChild { get; set; }
    }

    class OrphanGrandParent
    {
        public OrphanParent? OrphanParent { get; set; }
    }
}
