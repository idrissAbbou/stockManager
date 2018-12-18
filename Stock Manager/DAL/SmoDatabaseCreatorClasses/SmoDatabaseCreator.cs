using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo.SqlEnum;

namespace DAL.SmoDatabaseCreatorClasses
{
    public class SmoDatabaseCreator
    {
        ConnectionSettings _connectionSetting;
        Server _server;
        Database _database;

        public SmoDatabaseCreator(sqlServerTypeEnum sqlServerType)
        {
            SetServer(sqlServerType);
        }

        public void SetServer(sqlServerTypeEnum sqlServerType)
        {
            switch (sqlServerType)
            {
                case sqlServerTypeEnum.sqlServer:
                    _server = new Server(@".");
                    break;
                case sqlServerTypeEnum.sqlServerExpress:
                    _server = new Server(@".\SQLEXPRESS");
                    break;
                default:
                    throw new ServerNotSupportedException();
            }
        }

        public void CreateDatabase()
        {
            _database = new Database(_server, "StockManager");
            _database.Create();
        }

        public void CreateTableProduct()
        {
            Table product = new Table(_database, "Product");


            Index index = new Index(product, "barecode_Index");
            index.IsClustered = true;
            IndexedColumn columnIndex = new IndexedColumn(index, "barecode", true);
            index.IndexedColumns.Add(columnIndex);


            Column column = new Column(product, "nameProduct", DataType.VarChar(50));
            product.Columns.Add(column);
            column = new Column(product, "priceProduct", DataType.Float);
            product.Columns.Add(column);
            column = new Column(product, "descriptionProduct", DataType.VarCharMax);
            product.Columns.Add(column);
            column = new Column(product, "imageProduct", DataType.VarBinaryMax);
            product.Columns.Add(column);
            column = new Column(product, "qteEnStockProduct", DataType.Int);
            product.Columns.Add(column);

            product.Create();

        }

    }
}
