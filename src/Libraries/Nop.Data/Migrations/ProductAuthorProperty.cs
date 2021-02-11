using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
using Nop.Core.Domain.Catalog;

namespace Nop.Data.Migrations
{
    [NopMigration("2020/02/12 01:38:10:0000000", "Product. Add Author property")]
    public class AddProductAuthorProperty: AutoReversingMigration
    {
        public override void Up()
        {
            Create.Column(nameof(Product.Author))
            .OnTable(nameof(Product))
            .AsString(255)
            .Nullable();
        }
    }
}
