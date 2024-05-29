using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StatScene : UI_Scene
{
    public enum GameObjects
    {
        HPBar,
        MPBar
    }
    public enum Texts
    {
        LevelText,
        PlayerNameText
    }

    public override bool Init()
    {
        if (base.Init() == false)
        {
            return false;
        }

        Bind<GameObject>(typeof(GameObjects));
        Bind<Text>(typeof(Texts));

        // Manager.Game.Player.GetComponent<PlayerStat>().OnStatusChange += ChangeStatus;

        return true;
    }

    /*private void ChangeStatus()
    {
        GetObject((int)GameObjects.HPBar).GetComponent<Slider>().value;

        int level;
        GetText((int)Texts.LevelText).GetComponent<Text>().text = $"LV {level}";
    }*/

}
