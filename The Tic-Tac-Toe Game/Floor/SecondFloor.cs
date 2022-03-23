            // Columns
            if (SecondFloor[0, 1].BackColor == Themes.FirstPlayer && SecondFloor[0, 1].BackColor == SecondFloor[0, 0].BackColor && hisTurn == true)
            {
                if (SecondFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (SecondFloor[0, 1].BackColor == Themes.FirstPlayer && SecondFloor[0, 1].BackColor == SecondFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (SecondFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (SecondFloor[2, 1].BackColor == Themes.FirstPlayer && SecondFloor[2, 1].BackColor == SecondFloor[2, 0].BackColor && hisTurn == true)
            {
                if (SecondFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (SecondFloor[2, 1].BackColor == Themes.FirstPlayer && SecondFloor[2, 1].BackColor == SecondFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (SecondFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }

            // Rows
            if (SecondFloor[1, 0].BackColor == Themes.FirstPlayer && SecondFloor[1, 0].BackColor == SecondFloor[0, 0].BackColor && hisTurn == true)
            {
                if (SecondFloor[2, 0].BackColor == Themes.BoardColor)
                    AI(2, 0);
            }

                if (SecondFloor[1, 0].BackColor == Themes.FirstPlayer && SecondFloor[1, 0].BackColor == SecondFloor[2, 0].BackColor && hisTurn == true)
                {
                    if (SecondFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }
            
            if (SecondFloor[1, 2].BackColor == Themes.FirstPlayer && SecondFloor[1, 2].BackColor == SecondFloor[0, 2].BackColor && hisTurn == true)
            {
                if (SecondFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (SecondFloor[1, 2].BackColor == Themes.FirstPlayer && SecondFloor[1, 2].BackColor == SecondFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (SecondFloor[0, 2].BackColor == Themes.BoardColor)
                        AI(0, 2);
                }