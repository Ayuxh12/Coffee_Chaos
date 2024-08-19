using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour {

    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    private void Start(){
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }
    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e ){
        if(e.selectedCounter == clearCounter){
            Hide();
        }
        else{
            Show();
        }
    }
    private void Show() {
        visualGameObject.SetActive(false);
    }
    private void Hide() {
        visualGameObject.SetActive(true);
    }

    
}
