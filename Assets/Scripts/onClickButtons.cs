using UnityEngine;
using System.Collections;

public class onClickButtons : MonoBehaviour {

	public void onClickButton1(){
		Application.LoadLevel("mini game");
	}

	public void onClickButton2(){
		Application.LoadLevel("mini game 2");
	}

    public void onClickButton3(){
        Application.Quit();
    }

}
