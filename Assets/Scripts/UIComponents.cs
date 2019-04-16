using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
public class UIComponents
{
    [Serializable]
      public class Hud  {
          [Header("Text")]
          public Text txtCoinCount;
          public Text txtLifeCount;
          [Header("Other")]
          public GameObject panelHud; 
      }

      public Hud hud;



    [Serializable]

      public class LevelCompletePanel   
      {
          [Header("Text")]
          public Text txtScore;
          [Header("Other")]
          public GameObject panel;
      }
      public LevelCompletePanel LCPanel;




    [Serializable]

      public class GameOverPanel   
      {
          [Header("Text")]
          public Text txtScore;
          [Header("Other")]
          public GameObject panel; 
      }

    public GameOverPanel gameOverPanel;

}
