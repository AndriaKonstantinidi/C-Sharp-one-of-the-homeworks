string[] websites =
            {
            "hsNameA.com", "hsNameB.net", "hsNameC.net",
            "hsNameD.com", "hsNameE.org", "hsNameF.org",
            "hsNameG.tv", "hsNameH.net", "hsNameI.tv"
};

var query = from i in websites
            select i.Split('.').Last();

foreach(var item in query)
{
    Console.WriteLine(item);
}