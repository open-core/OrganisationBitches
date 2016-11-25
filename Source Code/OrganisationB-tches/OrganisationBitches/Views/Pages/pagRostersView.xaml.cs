﻿using OrganisationBitches.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OrganisationBitches.Views.Pages
{
    /// <summary>
    /// Interaction logic for pagRostersView.xaml
    /// </summary>
    public partial class pagRostersView : Page
    {
        public pagRostersView()
        {
            InitializeComponent();
        }

        #region Dependency Properties

        public bool PageVisible
        {
            get { return (bool)GetValue(PageVisibleProperty); }
            set { SetValue(PageVisibleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PageVisible.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PageVisibleProperty =
            DependencyProperty.Register("PageVisible", typeof(bool), typeof(pagRostersView), new PropertyMetadata(false));



        public bool CanEditEntries
        {
            get { return (bool)GetValue(CanEditEntriesProperty); }
            set { SetValue(CanEditEntriesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CanEditEntries.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CanEditEntriesProperty =
            DependencyProperty.Register("CanEditEntries", typeof(bool), typeof(pagRostersView), new PropertyMetadata(false));

        #endregion

        #region Event Handlers

        private void UserChanged()
        {
            if (DataHandler.pmSelectedPerson != null)
            {
                CanEditEntries = DataHandler.pmSelectedPerson.UserLevel.CanEditAllUsersData;
                PageVisible = true;
            }
            else
            {
                CanEditEntries = false;
                PageVisible = false;
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataHandler.UserChanged += new ViewModels.EventHandler(UserChanged);
            UserChanged();
        }

        #endregion

        private void btnNewRoster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditRoster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveRoster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteRoster_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
