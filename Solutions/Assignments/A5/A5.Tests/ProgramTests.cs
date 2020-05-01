using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace A5.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void PatientClassTests()
        {
            Patient p1 = new Patient("Pari", "Mohammadi", "Covid-19", false);
            Assert.AreEqual(p1.Disease, "Covid-19");
            Assert.AreEqual(p1.Firstname, "Pari");
            Assert.AreEqual(p1.Lastname, "Mohammadi");
            Assert.AreEqual(p1.Recovered, false);
        }
        [TestMethod]
        public void AddingPatientsToGeneralPractitioner()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general1;
            general.Acceptable(p1);
            general.Acceptable(p2);
            general.Acceptable(p3);
            general.Acceptable(p4);
            general.Acceptable(p5);
            general.Acceptable(p6);

            Assert.AreEqual(general.patients.Count, 2);
        }
        [TestMethod]
        public void GraduatingGenerals()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general3;
            general.Acceptable(p1);
            general.Acceptable(p2);
            general.Acceptable(p3);
            general.Acceptable(p4);
            general.Acceptable(p5);
            general.Acceptable(p6);

            Assert.AreEqual(general.GraduatedFrom(), "Reza Ghiasi is graduated from Tehran University");
        }
        [TestMethod]
        public void WorkingGenerals()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;


            GeneralPractitioner general = TestData.general3;
            general.Acceptable(p1);
            general.Acceptable(p2);
            general.Acceptable(p3);
            general.Acceptable(p4);
            general.Acceptable(p5);
            general.Acceptable(p6);

            Assert.AreEqual(general.Work(), "This General Practitioner works on General Practitioner");
        }
        [TestMethod]
        public void AddingPatientsToDentist()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist1;
            dentist.Acceptable(p1);
            dentist.Acceptable(p2);
            dentist.Acceptable(p3);

            Assert.AreEqual(dentist.patients.Count , 2);
        }
        [TestMethod]
        public void GraduatingDentists()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist2;
            dentist.Acceptable(p1);
            dentist.Acceptable(p2);
            dentist.Acceptable(p3);

            Assert.AreEqual(dentist.GraduatedFrom(), "Hamid Dehghan is graduated from Shahid Beheshti");
        }
        [TestMethod]
        public void WorkingDentists()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;

            Dentist dentist = TestData.dentist2;
            dentist.Acceptable(p1);
            dentist.Acceptable(p2);
            dentist.Acceptable(p3);

            Assert.AreEqual(dentist.Work(), "This Dentist works on Dental");
        }
        [TestMethod]
        public void AddingPatientsToSurgeon()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon1;
            surgeon.Acceptable(p1);
            surgeon.Acceptable(p2);
            surgeon.Acceptable(p3);
            surgeon.Acceptable(p4);
            surgeon.Acceptable(p5);
            surgeon.Acceptable(p6);

            Assert.AreEqual(surgeon.patients.Count, 2);
        }
        [TestMethod]
        public void GraduatingSurgeons()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon5;
            surgeon.Acceptable(p1);
            surgeon.Acceptable(p2);
            surgeon.Acceptable(p3);
            surgeon.Acceptable(p4);
            surgeon.Acceptable(p5);
            surgeon.Acceptable(p6);

            Assert.AreEqual(surgeon.GraduatedFrom(), "Reza Badiei is graduated from McGill University");

        }
        [TestMethod]
        public void WorkingSurgeons()
        {
            Patient p1 = TestData.patient1_dental;
            Patient p2 = TestData.patient2_dental;
            Patient p3 = TestData.patient1_toOperation;
            Patient p4 = TestData.patient1_general;
            Patient p5 = TestData.patient2_toOperation;
            Patient p6 = TestData.patient2_general;

            Surgeon surgeon = TestData.surgeon5;
            surgeon.Acceptable(p1);
            surgeon.Acceptable(p2);
            surgeon.Acceptable(p3);
            surgeon.Acceptable(p4);
            surgeon.Acceptable(p5);
            surgeon.Acceptable(p6);

            Assert.AreEqual(surgeon.Work(), "This Surgeon works on Surgeon");

        }
        [TestMethod]
        public void ListOfRecoveredPatientsTests()
        {
            Doctors<Dentist> doctorsDentist = new Doctors<Dentist>();
            Doctors<GeneralPractitioner> doctorsGeneral = new Doctors<GeneralPractitioner>();
            Doctors<Surgeon> doctorsSurgeon = new Doctors<Surgeon>();

            Dentist dentist1 = TestData.dentist1;
            dentist1.patients = TestData.patientListDental1;
            Dentist dentist2 = TestData.dentist2;
            dentist2.patients = TestData.patientListDental2;
            Dentist dentist3 = TestData.dentist3;
            dentist3.patients = TestData.patientListDental3;

            GeneralPractitioner general1 = TestData.general1;
            general1.patients = TestData.patientListGeneral1;
            GeneralPractitioner general2 = TestData.general2;
            general2.patients = TestData.patientListGeneral2;
            GeneralPractitioner general3 = TestData.general3;
            general3.patients = TestData.patientListGeneral3;

            Surgeon Surgeon1 = TestData.surgeon1;
            Surgeon1.patients = TestData.patientListSurgeon1;
            Surgeon Surgeon2 = TestData.surgeon2;
            Surgeon2.patients = TestData.patientListSurgeon2;
            Surgeon Surgeon3 = TestData.surgeon3;
            Surgeon3.patients = TestData.patientListSurgeon3;


            doctorsDentist.AddDoctor(TestData.dentist1);
            doctorsDentist.AddDoctor(TestData.dentist2);
            doctorsDentist.AddDoctor(TestData.dentist3);

            doctorsGeneral.AddDoctor(TestData.general1);
            doctorsGeneral.AddDoctor(TestData.general2);
            doctorsGeneral.AddDoctor(TestData.general3);

            doctorsSurgeon.AddDoctor(TestData.surgeon1);
            doctorsSurgeon.AddDoctor(TestData.surgeon2);
            doctorsSurgeon.AddDoctor(TestData.surgeon3);

            var result1 = doctorsDentist.ListOfRecoveredPatients();
            var exp1 = new List<string>() { "Ali Zakeri","Kasra Aghaei","Asghar Masoudi","Pouria Miri" };
            CollectionAssert.AreEqual(result1, exp1);

            var result2 = doctorsGeneral.ListOfRecoveredPatients();
            var exp2 = new List<string>() { "Ali Zakeri", "Zahra Harati", "Salman Danaei", "Kasra Aghaei", "Mousa Rezaei", "Asghar Masoudi", "Pouria Miri" };
            CollectionAssert.AreEqual(result2, exp2);

            var result3 = doctorsSurgeon.ListOfRecoveredPatients();
            var exp3 = new List<string>() { "Ali Zakeri", "Zahra Harati", "Salman Danaei", "Kasra Aghaei", "Asghar Masoudi","Akbar Kolme", "Pariya Lolaei", "Pouria Miri" };
            CollectionAssert.AreEqual(result3, exp3);
        }
        [TestMethod]
        public void SortingDoctorsTests()
        {
            Doctors<Dentist> doctorsDentist = new Doctors<Dentist>();
            Doctors<GeneralPractitioner> doctorsGeneral = new Doctors<GeneralPractitioner>();
            Doctors<Surgeon> doctorsSurgeon = new Doctors<Surgeon>();

            Dentist dentist1 = TestData.dentist1;
            dentist1.patients = TestData.patientListDental1;
            Dentist dentist2 = TestData.dentist2;
            dentist2.patients = TestData.patientListDental2;
            Dentist dentist3 = TestData.dentist3;
            dentist3.patients = TestData.patientListDental3;

            GeneralPractitioner general1 = TestData.general1;
            general1.patients = TestData.patientListGeneral1;
            GeneralPractitioner general2 = TestData.general2;
            general2.patients = TestData.patientListGeneral2;
            GeneralPractitioner general3 = TestData.general3;
            general3.patients = TestData.patientListGeneral3;

            Surgeon Surgeon1 = TestData.surgeon1;
            Surgeon1.patients = TestData.patientListSurgeon1;
            Surgeon Surgeon2 = TestData.surgeon2;
            Surgeon2.patients = TestData.patientListSurgeon2;
            Surgeon Surgeon3 = TestData.surgeon3;
            Surgeon3.patients = TestData.patientListSurgeon3;


            doctorsDentist.AddDoctor(TestData.dentist1);
            doctorsDentist.AddDoctor(TestData.dentist2);
            doctorsDentist.AddDoctor(TestData.dentist3);

            doctorsGeneral.AddDoctor(TestData.general1);
            doctorsGeneral.AddDoctor(TestData.general2);
            doctorsGeneral.AddDoctor(TestData.general3);

            doctorsSurgeon.AddDoctor(TestData.surgeon1);
            doctorsSurgeon.AddDoctor(TestData.surgeon2);
            doctorsSurgeon.AddDoctor(TestData.surgeon3);

            var result1 = doctorsDentist.SortDoctors();
            var exp1 = new List<string>() { "Tohid Mesbahi", "Siamak Azari" , "Hamid Dehghan" };
            CollectionAssert.AreEqual(result1, exp1);

            var result2 = doctorsGeneral.SortDoctors();
            var exp2 = new List<string>() { "Reza Ghiasi","Rahim Jamaat","Ramin Raji"};
            CollectionAssert.AreEqual(result2, exp2);

            var result3 = doctorsSurgeon.SortDoctors();
            var exp3 = new List<string>() {"Ramtin Shakeri", "Mohammadreza Karbasi", "Saeid Barikani" };
            CollectionAssert.AreEqual(result3, exp3);
        }
    }
}