using EnterpriseManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WebEye.Controls.Wpf;

namespace EnterpriseManagement.Desktop.ViewModels
{
    public class IDCardViewModel : ViewModelBase
    {
        private string cardType;

        public string CardType
        {
            get { return cardType; }
            set
            {
                if (cardType != value)
                {
                    cardType = value;
                    NotifyPropertyChanged("CardType");
                }
            }
        }

        private int cardTypeSelectedIndex;

        public int CardTypeSelectedIndex
        {
            get { return cardTypeSelectedIndex; }
            set
            {
                if (cardTypeSelectedIndex != value)
                {
                    cardTypeSelectedIndex = value;
                    NotifyPropertyChanged("CardTypeSelectedIndex");
                }
            }
        }

        private BitmapImage uploadedImage;

        public BitmapImage UploadedImage
        {
            get { return uploadedImage; }
            set
            {
                if (uploadedImage != value)
                {
                    uploadedImage = value;
                    NotifyPropertyChanged("UploadedImage");
                }
            }
        }

        private StaffViewModel selectedStaff;

        public StaffViewModel SelectedStaff
        {
            get { return selectedStaff; }
            set
            {
                if (selectedStaff != value)
                {
                    selectedStaff = value;
                    NotifyPropertyChanged("SelectedStaff");
                }
            }
        }

        private SMStudentInformation selectedStudent;

        public SMStudentInformation SelectedStudent
        {
            get { return selectedStudent; }
            set
            {
                if (selectedStudent != value)
                {
                    selectedStudent = value;
                    NotifyPropertyChanged("SelectedStudent");
                }
            }
        }

        private string cardID;

        public string CardID
        {
            get { return cardID; }
            set
            {
                if (cardID != value)
                {
                    cardID = value;
                    NotifyPropertyChanged("CardID");
                }
            }
        }

        private string cardSurname;

        public string CardSurname
        {
            get { return cardSurname; }
            set
            {
                if (cardSurname != value)
                {
                    cardSurname = value;
                    NotifyPropertyChanged("CardSurname");
                }
            }
        }

        private string cardOtherNames;

        public string CardOtherNames
        {
            get { return cardOtherNames; }
            set
            {
                if (cardOtherNames != value)
                {
                    cardOtherNames = value;
                    NotifyPropertyChanged("CardOtherNames");
                }
            }
        }


        private string bloodGroup;

        public string BloodGroup
        {
            get { return bloodGroup; }
            set
            {
                if (bloodGroup != value)
                {
                    bloodGroup = value;
                    NotifyPropertyChanged("BloodGroup");
                }
            }
        }

        private string nextOfKinPhoneNumber;

        public string NextOfKinPhoneNumber
        {
            get { return nextOfKinPhoneNumber; }
            set
            {
                if (nextOfKinPhoneNumber != value)
                {
                    nextOfKinPhoneNumber = value;
                    NotifyPropertyChanged("NextOfKinPhoneNumber");
                }
            }
        }

        private DateTime expiryDate;

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set
            {
                if (expiryDate != value)
                {
                    expiryDate = value;
                    NotifyPropertyChanged("ExpiryDate");
                }
            }
        }


        private Visibility cameraOverlayVisibility;

        public Visibility CameraOverlayVisibility
        {
            get { return cameraOverlayVisibility; }
            set
            {
                if (cameraOverlayVisibility != value)
                {
                    cameraOverlayVisibility = value;
                    NotifyPropertyChanged("CameraOverlayVisibility");
                }
            }
        }

        private WebCameraId selectedCamera;

        public WebCameraId SelectedCamera
        {
            get { return selectedCamera; }
            set
            {
                if (selectedCamera != value)
                {
                    selectedCamera = value;
                    NotifyPropertyChanged("SelectedCamera");
                }
            }
        }

        private ObservableCollection<WebCameraId> availableCameras;

        public ObservableCollection<WebCameraId> AvailableCameras
        {
            get { return availableCameras; }
            set
            {
                if (availableCameras != value)
                {
                    availableCameras = value;
                    NotifyPropertyChanged("AvailableCameras");
                }
            }
        }

        private bool isCapturing;

        public bool IsCapturing
        {
            get { return isCapturing; }
            set
            {
                if (isCapturing != value)
                {
                    isCapturing = value;
                    NotifyPropertyChanged("IsCapturing");
                }
            }
        }

        private bool isPreviewing;

        public bool IsPreviewing
        {
            get { return isPreviewing; }
            set
            {
                if (isPreviewing != value)
                {
                    isPreviewing = value;
                    NotifyPropertyChanged("IsPreviewing");
                }
            }
        }
    
        private Visibility imagePreviewVisibility;

        public Visibility ImagePreviewVisibility
        {
            get { return imagePreviewVisibility; }
            set
            {
                if (imagePreviewVisibility != value)
                {
                    imagePreviewVisibility = value;
                    NotifyPropertyChanged("ImagePreviewVisibility");
                }
            }
        }

        private HRStaffCardTemplate staffCardTemplate;

        public HRStaffCardTemplate StaffCardTemplate
        {
            get { return staffCardTemplate; }
            set
            {
                if (staffCardTemplate != value)
                {
                    staffCardTemplate = value;
                    NotifyPropertyChanged("StaffCardTemplate");
                }
            }
        }

        private SMStudentsCardTemplate studentCardTemplate;

        public SMStudentsCardTemplate StudentCardTemplate
        {
            get { return studentCardTemplate; }
            set
            {
                if (studentCardTemplate != value)
                {
                    studentCardTemplate = value;
                    NotifyPropertyChanged("StudentCardTemplate");
                }
            }
        }
    }
}
