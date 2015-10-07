using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ServiceModel;
using System.ServiceModel.Description;
using Mcs.Service;
using System.Net;
using System.IO;

namespace Mcs.Server.Test
{
    /// <summary>
    /// Сводное описание для UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private ServiceHost _placeServiceHost;
        private const string ServiceAddress = "http://localhost:987/PlaceService";

        [TestInitialize]
        public void TestInitialize()
        {
            WebHttpBinding httpBinding = new WebHttpBinding();
            _placeServiceHost = new ServiceHost(typeof(PlaceService));
            _placeServiceHost.AddServiceEndpoint(typeof(IPlaceService), httpBinding, ServiceAddress);
            _placeServiceHost.Description.Behaviors.Add(
                new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true,
                    HttpGetUrl = new Uri(ServiceAddress)
                });
            _placeServiceHost.Open();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _placeServiceHost.Close();
        }

        [TestMethod]
        public void TestMethod1()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ServiceAddress + "/place");
            request.Method = RequestMethod.GET;
            var response = request.GetResponse();
            StreamReader responseStream = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
            var responseString = responseStream.ReadToEnd();
            responseStream.Close();
        }
    }
}
