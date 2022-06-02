// Columns
if (FirstFloor[0, 0].BackColor == Themes.FirstPlayer && FirstFloor[0, 0].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[0, 1].BackColor == Themes.BoardColor)
        AI(0, 1, 1);
}

if (FirstFloor[1, 0].BackColor == Themes.FirstPlayer && FirstFloor[1, 0].BackColor == FirstFloor[1, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 1);
}

if (FirstFloor[2, 0].BackColor == Themes.FirstPlayer && FirstFloor[2, 0].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[2, 1].BackColor == Themes.BoardColor)
        AI(2, 1, 1);
}

// Rows
if (FirstFloor[0, 0].BackColor == Themes.FirstPlayer && FirstFloor[0, 0].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 0].BackColor == Themes.BoardColor)
        AI(1, 0, 1);
}

if (FirstFloor[0, 1].BackColor == Themes.FirstPlayer && FirstFloor[0, 1].BackColor == FirstFloor[2, 1].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 1);
}

if (FirstFloor[0, 2].BackColor == Themes.FirstPlayer && FirstFloor[0, 2].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 2].BackColor == Themes.BoardColor)
        AI(1, 2, 1);
}

// Diagonal

if (FirstFloor[0, 0].BackColor == Themes.FirstPlayer && FirstFloor[0, 0].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 1);
}

if (FirstFloor[2, 0].BackColor == Themes.FirstPlayer && FirstFloor[2, 0].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
{
    if (FirstFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 1);
}

// Second floor

// Columns
if (SecondFloor[0, 0].BackColor == Themes.FirstPlayer && SecondFloor[0, 0].BackColor == SecondFloor[0, 2].BackColor && hisTurn == true)
{
    if (SecondFloor[0, 1].BackColor == Themes.BoardColor)
        AI(0, 1, 2);
}

if (SecondFloor[2, 0].BackColor == Themes.FirstPlayer && SecondFloor[2, 0].BackColor == SecondFloor[2, 2].BackColor && hisTurn == true)
{
    if (SecondFloor[2, 1].BackColor == Themes.BoardColor)
        AI(2, 1, 2);
}

// Rows
if (SecondFloor[0, 0].BackColor == Themes.FirstPlayer && SecondFloor[0, 0].BackColor == SecondFloor[2, 0].BackColor && hisTurn == true)
{
    if (SecondFloor[1, 0].BackColor == Themes.BoardColor)
        AI(1, 0, 2);
}

if (SecondFloor[0, 2].BackColor == Themes.FirstPlayer && SecondFloor[0, 2].BackColor == SecondFloor[2, 2].BackColor && hisTurn == true)
{
    if (SecondFloor[1, 2].BackColor == Themes.BoardColor)
        AI(1, 2, 2);
}

// Third floor

// Columns
if (ThirdFloor[0, 0].BackColor == Themes.FirstPlayer && ThirdFloor[0, 0].BackColor == ThirdFloor[0, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[0, 1].BackColor == Themes.BoardColor)
        AI(0, 1, 3);
}

if (ThirdFloor[1, 0].BackColor == Themes.FirstPlayer && ThirdFloor[1, 0].BackColor == ThirdFloor[1, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 3);
}

if (ThirdFloor[2, 0].BackColor == Themes.FirstPlayer && ThirdFloor[2, 0].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[2, 1].BackColor == Themes.BoardColor)
        AI(2, 1, 3);
}

// Rows
if (ThirdFloor[0, 0].BackColor == Themes.FirstPlayer && ThirdFloor[0, 0].BackColor == ThirdFloor[2, 0].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 0].BackColor == Themes.BoardColor)
        AI(1, 0, 3);
}

if (ThirdFloor[0, 1].BackColor == Themes.FirstPlayer && ThirdFloor[0, 1].BackColor == ThirdFloor[2, 1].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 3);
}

if (ThirdFloor[0, 2].BackColor == Themes.FirstPlayer && ThirdFloor[0, 2].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 2].BackColor == Themes.BoardColor)
        AI(1, 2, 3);
}

// Diagonal

if (ThirdFloor[0, 0].BackColor == Themes.FirstPlayer && ThirdFloor[0, 0].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 3);
}

if (ThirdFloor[2, 0].BackColor == Themes.FirstPlayer && ThirdFloor[2, 0].BackColor == ThirdFloor[0, 2].BackColor && hisTurn == true)
{
    if (ThirdFloor[1, 1].BackColor == Themes.BoardColor)
        AI(1, 1, 3);
}