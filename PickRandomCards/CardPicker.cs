using System;
namespace PickRandomCards
{
	public class CardPicker

	{
		static Random random = new Random();

		public static string[] PickSomeCards(int numberOfCards)
		{
			string[] pickedCards = new string[numberOfCards];
			for (int i = 0; i < numberOfCards; i++)
			{
				pickedCards[i] = RandomValue() + " of " + RandomSuit();
			}
			return pickedCards;
		}

        private static string RandomValue()
        {
			// gets a randome number between 1 and 13
			int value = random.Next(1, 14);
			// if the number is 1 return string Ace
			if (value == 1) return "Ace";
			//if the number is 11 return string Jack
			if (value == 11) return "Jack";
			// if the number is 12 return string Queen
			if (value == 12) return "Queen";
			//if the number is 12 return string King
			if (value == 13) return "King";
			// if none of above return the number
			return value.ToString();
			{

			}
			{

			}
        }


		private static string RandomSuit()
		{
			// get a randome number from 1 to 4
			int value = random.Next(1, 5);

			// if it's 1 return the string Spades
			if (value == 1) return "Spades";
			// if it's 2 return the string Hearts
			if (value == 2) return "Hearts";
			//if it's 3 return the string clubs
			if (value == 3) return "Clubs";
			return "Diamonds";

			{

			}
			{

			}
		}
    }

}

