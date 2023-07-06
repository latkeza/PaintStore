<Query Kind="Statements">
  <Connection>
    <ID>5e84ac4a-93b3-40ad-9eeb-89edb4cc1fe4</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>.</Server>
    <Database>PaintStore</Database>
    <DisplayName>PaintStore</DisplayName>
    <DriverData>
      <EncryptSqlTraffic>True</EncryptSqlTraffic>
      <PreserveNumeric1>True</PreserveNumeric1>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

var allStores = Stores.Select(x => new
{
	StoreName = x.StoreName
}).Dump();

var storeId = 1;

var StoreProduct = Store_Products.Where(x => x.StoreID == storeId)
								.Select(y => new
								{
									ProductName = y.Product.ProductName,
									Description = y.Product.Description,
									Price = y.Product.Price
								}).ToList().Dump();