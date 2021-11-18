using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreHasDataNestedOwnedTypes
{
    public class EntityLevel1
    {
        protected EntityLevel1() { }

        public EntityLevel1(Guid id, OwnedEntity1 ownedEntity1)
        {
            Id = id;
            OwnedEntity1 = ownedEntity1;
        }


        public Guid Id { get; set; }

        public OwnedEntity1 OwnedEntity1 { get; set; }


        #region Only for HasData
        public static EntityLevel1 PredefinedEntity11 { get; } =
            new(
                Guid.Parse("96e1d442-bdd0-4c6f-9d01-624b27abbac3"),
                new OwnedEntity1 { Id = Guid.Parse("8f8eea73-0b43-412a-b0aa-a9338db6e067"), MyProperty = "Hello" }
            );

        public static EntityLevel1 PredefinedEntity12 { get; } =
           new(
               Guid.Parse("aae51dac-016e-472e-ad51-2f09f8cb9fbb"),
               new OwnedEntity1 { Id = Guid.Parse("701b2c44-c41f-450a-bc80-626b8045373d"), MyProperty = "Hello" }
           );

        public static IReadOnlyList<EntityLevel1> All { get; } = new List<EntityLevel1>(new[] { PredefinedEntity11, PredefinedEntity12 }).AsReadOnly();
        #endregion
    }

    public class OwnedEntity1
    {
        public Guid Id { get; set; }
        public string MyProperty { get; set; }
    }
}
