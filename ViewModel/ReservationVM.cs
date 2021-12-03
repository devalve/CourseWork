﻿using CourseWork.Model;
using CourseWork.Model.Data;
using CourseWork.Model.Data.Service;
using CourseWork.Utils;
using System;
using System.Windows;

namespace CourseWork.ViewModel
{
    public class ReservationVM : BaseVM
    {
        private string nickname = AuthVM.Nickname;
        #region PROPERTIES
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        private TimeSpan timeFrom = ReservationService
                                                    .GetReservationInfo(FillUtil.ROW, FillUtil.COLUMN, FillUtil.PAGE, AuthVM.Nickname)
                                                    .TimeFrom;
        public TimeSpan TimeFrom
        {
            get { return timeFrom; }
            set { timeFrom = value; NotifyPropertyChanged(nameof(TimeFrom)); }
        }

        private TimeSpan timeTo = ReservationService
                                                .GetReservationInfo(FillUtil.ROW, FillUtil.COLUMN, FillUtil.PAGE, AuthVM.Nickname)
                                                .TimeTo;
        public TimeSpan TimeTo
        {
            get { return timeTo; }
            set { timeTo = value; NotifyPropertyChanged(nameof(TimeTo)); }
        }

        private string members = ReservationService.GetReservationInfo(FillUtil.ROW, FillUtil.COLUMN, FillUtil.PAGE, AuthVM.Nickname).Members;

        public string Members
        {
            get { return members; }
            set { members = value; NotifyPropertyChanged(nameof(Members)); }
        }
        #endregion

        #region METHODS
        private void _AddNewReservation()
        {
            if (Math.Abs(TimeFrom.TotalMinutes - TimeTo.TotalMinutes) > 30)
            {
                ReservationService.CreateReservation(FillUtil.ROW,
                                         FillUtil.COLUMN,
                                         FillUtil.PAGE,
                                         AuthVM.Nickname,
                                         Members,
                                         TimeFrom,
                                         TimeTo);
                MessageBox.Show("Reservation has been successfully created. You can close this window", "Success!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else MessageBox.Show("The time interval should be more than 30 minutes", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void _EditReservation()
        {
            if (Math.Abs(TimeFrom.TotalMinutes - TimeTo.TotalMinutes) > 30)
            {
                ReservationService.EditReservation(FillUtil.ROW,
                                         FillUtil.COLUMN,
                                         FillUtil.PAGE,
                                         AuthVM.Nickname,
                                         Members,
                                         TimeFrom,
                                         TimeTo);
                MessageBox.Show("Reservation has been successfully edit. You can close this window", "Success!", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            }
            else MessageBox.Show("Something wrong. Check data", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void _OnClosed()
        {
            FillUtil.FillContentGrid(FillUtil.CONTENT_GRID, FillUtil.PAGE);
        }
        #endregion

        #region COMMANDS

        private readonly RelayCommand addNewReservation;
        public RelayCommand AddNewReservation { get => addNewReservation ?? new(o => _AddNewReservation()); }


        private readonly RelayCommand onClosed;
        public RelayCommand OnClosed { get => onClosed ?? new(o => _OnClosed()); }


        private readonly RelayCommand editReservation;
        public RelayCommand EditReservation { get => editReservation ?? new(o => _EditReservation()); }
        #endregion  
    }
}