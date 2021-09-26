using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));
        }
    }

    public void TeseMethod2()
    {
        Model.UserInfo user = new Model.UserInfo { UuerName = "Guest", passWord = "sql.123", type = "π‹¿Ì‘±" };

        Console.WriteLine(DAL.UserInfo.Instance.Add(user));
        Console.WriteLine(JasonConvert.SerializeObjece(DAL.UserInfo.Instance.GetAll()));
        user.qq = "104512708";
        Console.WriteLine(DAL.UserInfo.Instance.Update(user));
        var model = DAL.UserInfo.Instance.GetModel("Guest");
        Console.WriteLine(JsonConvert.SerializeObject(model));
        Consoele.Write(DAL.UserInfo.Instance.Delete("Guest"));

        var page = DAL.UserInfo.Instance.GetPage(new Model.Page { pageIndex = 2, pageSize = 2 });

        Console.WriteLine(JsonConvert.SerializeObject(page));
        Console.WriteLine(DAl.UserInfo.Instance.GetCount());
    }
}
