using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ControllerButtonPusher : MonoBehaviour {

    private String code;
	private String rightCode;
	public AudioSource hit;
	public AudioSource wrong;
	public AudioSource right;
    public bool open;
    public Text CodeNum;

	private Rigidbody rb;


    private void setText(int num)
    {
        CodeNum.text += num.ToString() + " ";
    }



	void Start ()
	{
        rightCode = "1111";
        code = "";
        CodeNum.text = "Code: ";
    }

	void FixedUpdate ()
	{
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Zero"))
        {
            code += "0";
            hit.Play();
            setText(0);
        }
		else if (other.gameObject.CompareTag("One"))
        {
            code += "1";
            hit.Play();
            setText(1);
        }
		else if (other.gameObject.CompareTag("Two"))
        {
            code += "2";
            hit.Play();
            setText(2);
        }
		else if (other.gameObject.CompareTag("Three"))
        {
            code += "3";
            hit.Play();
            setText(3);
        }
		else if (other.gameObject.CompareTag("Four"))
        {
            code += "4";
            hit.Play();
            setText(4);
        }
		else if (other.gameObject.CompareTag("Five"))
        {
            code += "5";
            hit.Play();
            setText(5);
        }
		else if (other.gameObject.CompareTag("Six"))
        {
            code += "6";
            hit.Play();
            setText(6);
        }
		else if (other.gameObject.CompareTag("Seven"))
        {
            code += "7";
            hit.Play();
            setText(7);
        }
		else if (other.gameObject.CompareTag("Eight"))
        {
            code += "8";
            hit.Play();
            setText(8);
        }
		else if (other.gameObject.CompareTag("Nine"))
        {
            code += "9";
            hit.Play();
            setText(9);
        }
		else if (other.gameObject.CompareTag("Green"))
		{
            if(code == rightCode)
             {
                    right.Play();
                    CodeNum.text += "right";
                    open = true;
             }
			else
			{
				wrong.Play();
				code = "";
                CodeNum.text = "Code: ";
			}
		}
		else if (other.gameObject.CompareTag("Red"))
		{
			wrong.Play();
			code = "";
            CodeNum.text = "Code: ";
		}




        //System.Threading.Thread.Sleep(2000);
    }
}
