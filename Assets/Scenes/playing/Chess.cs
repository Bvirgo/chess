﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess{
	public const int KING = 1;    // 帅
	public const int ADVISOR = 2; // 士
	public const int BISHOP = 3;  // 象
	public const int KNIGHT = 4;  // 马
	public const int ROOK = 5;    // 车
	public const int CANNON = 6;  // 炮
	public const int PAWN = 7;    // 兵
	public bool red_turn = true;  // 红方走棋
	public bool is_red = true;

	// 初始棋盘
	public int[] board = new Int32[]{
		15, 14, 13, 12, 11, 12, 13, 14, 15,
		 0,  0,  0,  0,  0,  0,  0,  0,  0,
		 0, 16,  0,  0,  0,  0,  0, 16,  0,
		 17, 0, 17,  0, 17,  0, 17,  0, 17,
		 0,  0,  0,  0,  0,  0,  0,  0,  0,
		 0,  0,  0,  0,  0,  0,  0,  0,  0,
		 7,  0,  7,  0,  7,  0,  7,  0,  7,
		 0,  6,  0,  0,  0,  0,  0,  6,  0,
		 0,  0,  0,  0,  0,  0,  0,  0,  0,
		 5,  4,  3,  2,  1,  2,  3,  4,  5,
	};

	public bool IsMyTurn(){
		return red_turn == is_red;
	}

	public bool IsMyCM(int row, int col){
		int i = (row - 1) * 9 + col - 1;
		int cm = board [i];

		if (0 == cm)
			return false;
		if (is_red && cm < 10)
			return true;
		if (!is_red && cm > 10)
			return true;

		return false;
	}

	int GetCM(int row, int col){
		int index = (row - 1) * 9 + col - 1;
		return board [index];
	}

	void SetCM(int row, int col, int cm){
		int index = (row - 1) * 9 + col - 1;
		board [index] = cm;
	}

	public bool CanMove(int sRow, int sCol, int dRow, int dCol){
		return true;
	}

	public void Move(int sRow, int sCol, int dRow, int dCol){
		int src = GetCM (sRow, sCol);
		SetCM (sRow, sCol, 0);
		SetCM (dRow, dCol, src);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}