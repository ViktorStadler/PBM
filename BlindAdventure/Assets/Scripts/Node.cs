﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Stadler Viktor
//Represents a node from a level
[System.Serializable]
public class Node{

	private Item item;
	private Quiz quiz = null;
	private Fight fight = null;
	private Steeplechase steepleChase = null;
	private bool nodeSolved = false; //if node is solved -> true

	public void setQuiz(Quiz quiz) {
		this.quiz = quiz;
	}

	public Quiz getQuiz(){
		return quiz;
	}

	public void setFight(Fight fight) {
		this.fight = fight;
	}

	public Fight getFight(){
		return fight;
	}

	public void setSteeplechase(Steeplechase steepleChase) {
		this.steepleChase = steepleChase;
	}

	public Steeplechase getSteeplechase(){
		return steepleChase;
	}

	public void setItem(Item item) {
		this.item = item;
	}

	public Item getItem(){
		return item;
	}

	public void setNodeSolved(bool nodeSolved) {
		this.nodeSolved = nodeSolved;
	}

	public bool getNodeSolved(){
		return nodeSolved;
	}
}
