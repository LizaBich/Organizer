using System;
using System.Collections.Generic;
using DI_container.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Organizer.Model;
using DI_container;
using Organizer.DataAccess;

namespace Organizer.DataAccessTests
{
    [TestClass]
    public class DataManagerTests
    {
        private Note _firstNote;
        private Note _secondNote;
        private DataManager _dataManager;
        private readonly IDiContainer _container = DiContainer.InitializeDiContainer();

        [TestInitialize]
        public void Initialize()
        {
            _container.Register<Note>();
            _container.Register<DataManager>();
            _container.Register<List<Note>>();
            _firstNote = _container.Resolve<Note>(parameters: new object[]{(sbyte)1, "Watch movie", "Watch Thor 3", DateTime.Now});
            _secondNote =
                _container.Resolve<Note>(parameters: new object[] {(sbyte)2, "Street", "Go for a walk", DateTime.Now});
            _dataManager = _container.Resolve<DataManager>(parameters: new object[]{_container});
        }

        [TestMethod]
        public void AddNotesToDbTest()
        {
            var list = _container.Resolve<List<Note>>();
            list.Add(_firstNote);
            list.Add(_secondNote);
            var result = _dataManager.AddToDatabase(list);
            Assert.AreEqual(true, result);
        }
    }
}
