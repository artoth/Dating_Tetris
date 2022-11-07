using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Flowers : MonoBehaviour
{
    
        public string[] dialogue;
        public Text dialogueText;
        public GameObject TextBox;
      
        public GameObject Option4;
        public GameObject Option5;

        public string targetScene;

        public GameObject Red;
        public GameObject Aqua;

        public Sprite LoveA;
        public Sprite LoveR;
        public Sprite HateA;
        public Sprite HateR;

        public int ChoiceMade;
        int dialogueNum = 0;

        public void ChoiceOption4()
        {
            TextBox.GetComponent<Text>().text = "Sunflowers personally";
            ChoiceMade = 1;
            targetScene = "OutsideSunflower" ;
            Invoke(nameof(ChangeScene), 2f);
        }
        public void ChoiceOption5()
        {
            TextBox.GetComponent<Text>().text = "I also really like tulips";
            ChoiceMade = 2;
            targetScene = "OutsideTulip";
            Invoke(nameof(ChangeScene), 2f);
    }
      

    private void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }

        private void Start()
        {
            dialogueText.text = dialogue[dialogueNum];

        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {

                if (dialogueNum < dialogue.Length - 1)
                {
                    dialogueNum++;
                    dialogueText.text = dialogue[dialogueNum];
                }
            }

            if(ChoiceMade == 1)
            {
            Aqua.gameObject.GetComponent<Image>().sprite = HateA;
            Red.gameObject.GetComponent<Image>().sprite = LoveR;
            }

            if(ChoiceMade == 2)
        {
            Aqua.gameObject.GetComponent<Image>().sprite = LoveA;
            Red.gameObject.GetComponent<Image>().sprite = HateR;
            
        }
            /*
            if (Input.GetMouseButtonDown(0))
            {
                if (dialogueNum < dialogue.Length - 1)
                {
                    dialogueNum--;
                    dialogueText.text = dialogue[dialogueNum];

                }
            }
            */
        }
    }

