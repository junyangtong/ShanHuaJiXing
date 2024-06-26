using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DialogueController))]
public class Pubu : Interactive
{
    private DialogueController dialogueController;
    public GameObject wall;
    public GameObject waterSp;
    private void Awake()
    {
        dialogueController = GetComponent<DialogueController>();
    }
    
    protected override void OnClickedAction()
    {
        // 播放使用物品的动画

        dialogueController.ShowdialogueFinish();

        //水精灵进入瀑布
        waterSp.SetActive(true);
        wall.SetActive(false);
    }
    public override void EmptyClicked()
    {
        if(isDone)
            dialogueController.ShowdialogueFinish();
        else
            dialogueController.ShowdialogueEmpty();
    }
}