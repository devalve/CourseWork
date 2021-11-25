namespace CourseWork.ViewModel
{
    public class ReservationCanvasVM : BaseVM
    { 
        private readonly string _nickname = AuthVM.Nickname;
        public static string UserIconPath { get => "/Resources/img/UserIcon.png"; }
        public string Nickname { get => _nickname ?? "Default user"; }
    }
}
