﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.Hearthstone;

namespace Hearthstone_Deck_Tracker
{
	/// <summary>
	/// Interaction logic for DeckSelectionDialog.xaml
	/// </summary>
	public partial class DeckSelectionDialog
	{
		public Deck SelectedDeck;

		public DeckSelectionDialog(IEnumerable<Deck> decks)
		{
			InitializeComponent();

			WindowStartupLocation = WindowStartupLocation.CenterScreen;

			DeckPickerList.Items.Clear();
			foreach(var deck in decks)
				DeckPickerList.Items.Add(deck);
		}

		private void DeckPickerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			SelectedDeck = DeckPickerList.SelectedItem as Deck;
			Close();
		}
	}
}