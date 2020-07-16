using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFGenerator.DAL
{
    public static class SqlQueries
    {
		public static String GetClients => @"
SELECT ID
		,[Name]
		,Street
		,City
		,[State]
		,Zip
		,Country
		,EmailAddress
		,OfficePhone
		,CreatedOn
		,LastModifiedOn
FROM dbo.Client";

	}
}
