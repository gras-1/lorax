using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogue_manager : MonoBehaviour
{

    public Text name;
    public Text dialogue;

    public Animator animate;



    private Queue<string> sentances;

    // Start is called before the first frame update
    void Start()
    {
        sentances = new Queue<string>();
    }
     void FixedUpdate()
    {
        if (Input.GetButtonDown("Submit"))
        {
            displaynext();
            Debug.Log("next");
        }
    }



    public void StartDialogue (dialogue Dialogue)
    {
        animate.SetBool("isopen", true );

        name.text = Dialogue.name;

        sentances.Clear();

        foreach (string sentance in Dialogue.sentances)
        {
            sentances.Enqueue(sentance);
        }
        displaynext ();
    }
    public void displaynext ()
    {
        if (sentances.Count == 0)
        {
            dialogueEnd();
            return;
        }
        string sentanceleft = sentances.Dequeue();
        dialogue.text = sentanceleft;
    }
    void dialogueEnd ()
    {
        animate.SetBool("isopen", false);
    }
    

    }





