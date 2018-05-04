using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class StaffViewModel : ViewModelBase
    {
        private string staffID;

        public string StaffID
        {
            get { return staffID; }
            set
            {
                if (staffID != value)
                {
                    staffID = value;
                    NotifyPropertyChanged("StaffID");
                }
            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (firstName != value)
                {
                    firstName = value;
                    NotifyPropertyChanged("FirstName");
                }
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (surname != value)
                {
                    surname = value;
                    NotifyPropertyChanged("Surname");
                }
            }
        }

        private string otherNames;

        public string OtherNames
        {
            get { return otherNames; }
            set
            {
                if (otherNames != value)
                {
                    otherNames = value;
                    NotifyPropertyChanged("OtherNames");
                }
            }
        }

        private HRTitle title;

        public HRTitle Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    NotifyPropertyChanged("Title");
                }
            }
        }

        private HRGender gender;

        public HRGender Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    NotifyPropertyChanged("Gender");
                }
            }
        }

        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    dateOfBirth = value;
                    NotifyPropertyChanged("DateOfBirth");
                }
            }
        }

        private HRStatus maritalStatus;

        public HRStatus MaritalStatus
        {
            get { return maritalStatus; }
            set
            {
                if (maritalStatus != value)
                {
                    maritalStatus = value;
                    NotifyPropertyChanged("MaritalStatus");
                }
            }
        }

        private HRNationality nationality;

        public HRNationality Nationality
        {
            get { return nationality; }
            set
            {
                if (nationality != value)
                {
                    nationality = value;
                    NotifyPropertyChanged("Nationality");
                }
            }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    NotifyPropertyChanged("PhoneNumber");
                }
            }
        }

        private string altPhoneNumber;

        public string AltPhoneNumber
        {
            get { return altPhoneNumber; }
            set
            {
                if (altPhoneNumber != value)
                {
                    altPhoneNumber = value;
                    NotifyPropertyChanged("AltPhoneNumber");
                }
            }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (emailAddress != value)
                {
                    emailAddress = value;
                    NotifyPropertyChanged("EmailAddress");
                }
            }
        }

        private string officialEmailAddress;

        public string OfficialEmailAddress
        {
            get { return officialEmailAddress; }
            set
            {
                if (officialEmailAddress != value)
                {
                    officialEmailAddress = value;
                    NotifyPropertyChanged("OfficialEmailAddress");
                }
            }
        }

        private string contactAddress;

        public string ContactAddress
        {
            get { return contactAddress; }
            set
            {
                if (contactAddress != value)
                {
                    contactAddress = value;
                    NotifyPropertyChanged("ContactAddress");
                }
            }
        }

        private HRStaffType staffType;

        public HRStaffType StaffType
        {
            get { return staffType; }
            set
            {
                if (staffType != value)
                {
                    staffType = value;
                    NotifyPropertyChanged("StaffType");
                }
            }
        }

        private HRStaff lineManager;

        public HRStaff LineManager
        {
            get { return lineManager; }
            set
            {
                if (lineManager != value)
                {
                    lineManager = value;
                    NotifyPropertyChanged("LineManager");
                }
            }
        }

        private HRDesignation designation;

        public HRDesignation Designation
        {
            get { return designation; }
            set
            {
                if (designation != value)
                {
                    designation = value;
                    NotifyPropertyChanged("Designation");
                }
            }
        }

        private HRDepartment department;

        public HRDepartment Department
        {
            get { return department; }
            set
            {
                if (department != value)
                {
                    department = value;
                    NotifyPropertyChanged("Department");
                }
            }
        }

        private decimal grossPay;

        public decimal GrossPay
        {
            get { return grossPay; }
            set
            {
                if (grossPay != value)
                {
                    grossPay = value;
                    NotifyPropertyChanged("GrossPay");
                }
            }
        }

        private bool isStaffActive;

        public bool IsStaffActive
        {
            get { return isStaffActive; }
            set
            {
                if (isStaffActive != value)
                {
                    isStaffActive = value;
                    NotifyPropertyChanged("IsStaffActive");
                }
            }
        }

        private bool isAcademicStaff;

        public bool IsAcademicStaff
        {
            get { return isAcademicStaff; }
            set
            {
                if (isAcademicStaff != value)
                {
                    isAcademicStaff = value;
                    NotifyPropertyChanged("IsAcademicStaff");
                }
            }
        }

        //private bool isAdminiStaff;

        //public bool IsAdminStaff
        //{
        //    get { return isAdminiStaff; }
        //    set
        //    {
        //        if (isAdminiStaff != value)
        //        {
        //            isAdminiStaff = value;
        //            NotifyPropertyChanged("IsNonAcademicStaff");
        //        }
        //    }
        //}

        private string accountNumber;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (accountNumber != value)
                {
                    accountNumber = value;
                    NotifyPropertyChanged("AccountNumber");
                }
            }
        }

        private HRAccountType accountType;

        public HRAccountType AccountType
        {
            get { return accountType; }
            set
            {
                if (accountType != value)
                {
                    accountType = value;
                    NotifyPropertyChanged("AccountType");
                }
            }
        }

        private HRBank bank;

        public HRBank Bank
        {
            get { return bank; }
            set
            {
                if (bank != value)
                {
                    bank = value;
                    NotifyPropertyChanged("Bank");
                }
            }
        }

        private string bankSortCode;

        public string BankSortCode
        {
            get { return bankSortCode; }
            set
            {
                if (bankSortCode != value)
                {
                    bankSortCode = value;
                    NotifyPropertyChanged("BankSortCode");
                }
            }
        }

        private string bankVerificationNumber;

        public string BankVerificationNumber
        {
            get { return bankVerificationNumber; }
            set
            {
                if (bankVerificationNumber != value)
                {
                    bankVerificationNumber = value;
                    NotifyPropertyChanged("BankVerificationNumber");
                }
            }
        }

        private bool isPayRent;

        public bool IsPayRent
        {
            get { return isPayRent; }
            set
            {
                if (isPayRent != value)
                {
                    isPayRent = value;
                    NotifyPropertyChanged("IsPayRent");
                }
            }
        }

        private bool isPayCarLoan;

        public bool IsPayCarLoan
        {
            get { return isPayCarLoan; }
            set
            {
                if (isPayCarLoan != value)
                {
                    isPayCarLoan = value;
                    NotifyPropertyChanged("IsPayCarLoan");
                }
            }
        }

        private decimal rentAmount;

        public decimal RentAmount
        {
            get { return rentAmount; }
            set
            {
                if (rentAmount != value)
                {
                    rentAmount = value;
                    NotifyPropertyChanged("RentAmount");
                }
            }
        }

        private decimal carLoanAmount;

        public decimal CarLoanAmount
        {
            get { return carLoanAmount; }
            set
            {
                if (carLoanAmount != value)
                {
                    carLoanAmount = value;
                    NotifyPropertyChanged("CarLoanAmount");
                }
            }
        }

        private string nokFirstName;

        public string NOKFirstName
        {
            get { return nokFirstName; }
            set
            {
                {
                    if (nokFirstName != value)
                    {
                        nokFirstName = value;
                        NotifyPropertyChanged("NOKFirstName");
                    }
                }
            }
        }

        private string nokSurname;

        public string NOKSurname
        {
            get { return nokSurname; }
            set
            {
                {
                    if (nokSurname != value)
                    {
                        nokSurname = value;
                        NotifyPropertyChanged("NOKSurname");
                    }
                }
            }
        }

        private string nokOtherNames;

        public string NOKOtherNames
        {
            get { return nokOtherNames; }
            set
            {
                if (nokOtherNames != value)
                {
                    nokOtherNames = value;
                    NotifyPropertyChanged("NOKOtherNames");
                }
            }
        }

        private HRTitle nokTitle;

        public HRTitle NOKTitle
        {
            get { return nokTitle; }
            set
            {
                if (nokTitle != value)
                {
                    nokTitle = value;
                    NotifyPropertyChanged("NOKTitle");
                }
            }
        }

        private HRRelationship relationship;

        public HRRelationship Relationship
        {
            get { return relationship; }
            set
            {
                if (relationship != value)
                {
                    relationship = value;
                    NotifyPropertyChanged("Relationship");
                }
            }
        }

        private string nokPhoneNumber;

        public string NOKPhoneNumber
        {
            get { return nokPhoneNumber; }
            set
            {
                if (nokPhoneNumber != value)
                {
                    nokPhoneNumber = value;
                    NotifyPropertyChanged("NOKPhoneNumber");
                }
            }
        }

        private string nokEmailAddress;

        public string NOKEmailAddress
        {
            get { return nokEmailAddress; }
            set
            {
                if (nokEmailAddress != value)
                {
                    nokEmailAddress = value;
                    NotifyPropertyChanged("NOKEmailAddress");
                }
            }
        }

        private string nokContactAddress;

        public string NOKContactAddress
        {
            get { return nokContactAddress; }
            set
            {
                if (nokContactAddress != value)
                {
                    nokContactAddress = value;
                    NotifyPropertyChanged("NOKContactAddress");
                }
            }
        }

        private HRQualification qualification;

        public HRQualification Qualification
        {
            get { return qualification; }
            set
            {
                if (qualification != value)
                {
                    qualification = value;
                    NotifyPropertyChanged("Qualification");
                }
            }
        }

        private string qualificationInstitution;

        public string QualificationInstitution
        {
            get { return qualificationInstitution; }
            set
            {
                if (qualificationInstitution != value)
                {
                    qualificationInstitution = value;
                    NotifyPropertyChanged("QualificationInstitution");
                }
            }
        }

        private ObservableCollection<HRDepartment> departments;

        public ObservableCollection<HRDepartment> Departments
        {
            get { return departments; }
            set
            {
                if (departments != value)
                {
                    departments = value;
                    NotifyPropertyChanged("Departments");
                }
            }
        }

        private ObservableCollection<HRStaff> staffs;

        public ObservableCollection<HRStaff> Staffs
        {
            get { return staffs; }
            set
            {
                if (staffs != value)
                {
                    staffs = value;
                    NotifyPropertyChanged("Staffs");
                }
            }
        }

        private ObservableCollection<HRAccountType> accountTypes;

        public ObservableCollection<HRAccountType> AccountTypes
        {
            get { return accountTypes; }
            set
            {
                if (accountTypes != value)
                {
                    accountTypes = value;
                    NotifyPropertyChanged("AccountTypes");
                }
            }
        }

        private ObservableCollection<HRBank> banks;

        public ObservableCollection<HRBank> Banks
        {
            get { return banks; }
            set
            {
                if (banks != value)
                {
                    banks = value;
                    NotifyPropertyChanged("Banks");
                }
            }
        }

        private ObservableCollection<HRStaffType> staffTypes;

        public ObservableCollection<HRStaffType> StaffTypes
        {
            get { return staffTypes; }
            set
            {
                if (staffTypes != value)
                {
                    staffTypes = value;
                    NotifyPropertyChanged("StaffTypes");
                }
            }
        }

        private ObservableCollection<HRRelationship> relationships;

        public ObservableCollection<HRRelationship> Relationships
        {
            get { return relationships; }
            set
            {
                if (relationships != value)
                {
                    relationships = value;
                    NotifyPropertyChanged("Relationships");
                }
            }
        }

        private ObservableCollection<HRTitle> titles;

        public ObservableCollection<HRTitle> Titles
        {
            get { return titles; }
            set
            {
                if (titles != value)
                {
                    titles = value;
                    NotifyPropertyChanged("Titles");
                }
            }
        }

        private ObservableCollection<HRTitle> nokTitles;

        public ObservableCollection<HRTitle> NOKTitles
        {
            get { return nokTitles; }
            set
            {
                if (nokTitles != value)
                {
                    nokTitles = value;
                    NotifyPropertyChanged("NOKTitles");
                }
            }
        }

        private ObservableCollection<HRNationality> nationalities;

        public ObservableCollection<HRNationality> Nationalities
        {
            get { return nationalities; }
            set
            {
                if (nationalities != value)
                {
                    nationalities = value;
                    NotifyPropertyChanged("Nationalities");
                }
            }
        }

        private ObservableCollection<HRStatus> maritalStatuses;

        public ObservableCollection<HRStatus> MaritalStatuses
        {
            get { return maritalStatuses; }
            set
            {
                if (maritalStatuses != value)
                {
                    maritalStatuses = value;
                    NotifyPropertyChanged("MaritalStatuses");
                }
            }
        }

        private ObservableCollection<HRDesignation> designations;

        public ObservableCollection<HRDesignation> Designations
        {
            get { return designations; }
            set
            {
                if (designations != value)
                {
                    designations = value;
                    NotifyPropertyChanged("Designations");
                }
            }
        }

        private ObservableCollection<HRGender> genders;

        public ObservableCollection<HRGender> Genders
        {
            get { return genders; }
            set
            {
                if (genders != value)
                {
                    genders = value;
                    NotifyPropertyChanged("Genders");
                }
            }
        }

        private ObservableCollection<HRQualification> qualifications;

        public ObservableCollection<HRQualification> Qualifications
        {
            get { return qualifications; }
            set
            {
                if (qualifications != value)
                {
                    qualifications = value;
                    NotifyPropertyChanged("Qualifications");
                }
            }
        }

        ////Add list for structure ID
    }
}
