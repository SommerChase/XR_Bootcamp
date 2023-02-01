using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    [SerializeField] private TMP_Text messageBoxTextField;
    [SerializeField] private TMP_InputField answerInputField;

    private string _question; 
    [SerializeField] private int answer;

    // Start is called before the first frame update
    void Start()
    {
        
        // Random numbers used for problem:
        int operand1 = Random.Range(1, 100);
        int operand2 = Random.Range(1, 100);

        if (Random.value < 0.5f)
        {
            _question = $"{operand1} + {operand2} = ?";
            answer = operand1 + operand2;
        }
        else
        {
            _question = $"{operand1} - {operand2} = ?";
            answer = operand1 - operand2;
            // hey
        }

        Debug.Log(operand1);
        Debug.Log(operand2);

        messageBoxTextField.text = _question;
        
        answerInputField.Select();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
