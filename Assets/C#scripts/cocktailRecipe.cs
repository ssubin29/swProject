using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class cocktailRecipe : MonoBehaviour
{
    public class cocktail
    {
        int cocktailKinds;
        int recommendedAmount;

        public int makingScore(int recommendAmount,int realAmount)
        {
            int minA = recommendAmount - 5;
            int maxA = recommendAmount + 5;
            int score = (minA<realAmount&&maxA>realAmount) ? 100 : 0;
            Debug.Log(score);
            return score;
        }
    }
    public void makingCocktail()
    {
        cocktail blackRussian = new cocktail();
        blackRussian.makingScore(30, 28);
    }



}
