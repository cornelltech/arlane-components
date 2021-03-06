﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RelatedProduct : MonoBehaviour {

	public string title;
	public string price;
	public string text;
	public Sprite img;

	private Text productTitleUIComponent;
	private Text productPriceUIComponent;
	private Text productTextUIComponent;
	private Image productImageUIComponent;

	// Use this for initialization
	void Start () {
		productTitleUIComponent = GameObject.FindGameObjectWithTag("Product Title").GetComponent<Text>();
		productTitleUIComponent.text = title;

		productPriceUIComponent = GameObject.FindGameObjectWithTag("Product Price").GetComponent<Text>();
		productPriceUIComponent.text = price;

		productTextUIComponent = GameObject.FindGameObjectWithTag("Product Text").GetComponent<Text>();
		productTextUIComponent.text = text;

		productImageUIComponent = GameObject.FindGameObjectWithTag("Product Image").GetComponent<Image>();
		productImageUIComponent.sprite = img;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
