﻿
using AppModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace Tests
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void ShouldLoadAllDrugs()
        {
            IModel model = new Model(new EmptyEventDispatcher());

            model.LoadDrugList();

            int expectedCount = 3;

            int actualCount = model.DrugList.Count;

            Assert.AreEqual(expectedCount, actualCount, "Drug count should be {0} and not {1}", expectedCount, actualCount);
        }

        [TestMethod]
        public void ShouldLoadAllDoctors()
        {
            IModel model = new Model(new EmptyEventDispatcher());

            model.LoadDoctorList();

            int expectedCount = 3;

            int actualCount = model.DoctorList.Count;

            Assert.AreEqual(expectedCount, actualCount, "Doctor count should be {0} and not {1}", expectedCount, actualCount);
        }

        [TestMethod]
        public void ShouldLoadAllPatients()
        {
            IModel model = new Model(new EmptyEventDispatcher());

            model.LoadPatientList();

            int expectedCount = 3;

            int actualCount = model.PatientList.Count;

            Assert.AreEqual(expectedCount, actualCount, "Patient count should be {0} and not {1}", expectedCount, actualCount);
        }

        [TestMethod]
        public void ShouldLoadAllPatientPrescriptions()
        {
            IModel model = new Model(new EmptyEventDispatcher());

            model.LoadPrescriptionList();

            int expectedCount = 2;

            int actualCount = model.PrescriptionList.Count;

            Assert.AreEqual(expectedCount, actualCount, "Prescription count should be {0} and not {1}", expectedCount, actualCount);
        }
    }
}
