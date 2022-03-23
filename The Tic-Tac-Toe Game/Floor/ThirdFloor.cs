            // Columns
            if (ThirdFloor[0, 1].BackColor == Themes.FirstPlayer && ThirdFloor[0, 1].BackColor == ThirdFloor[0, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (ThirdFloor[0, 1].BackColor == Themes.FirstPlayer && ThirdFloor[0, 1].BackColor == ThirdFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[1, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[1, 2].BackColor == Themes.BoardColor)
                    AI(1, 2);
            }

                if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[1, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[1, 0].BackColor == Themes.BoardColor)
                        AI(1, 0);
                }


            if (ThirdFloor[2, 1].BackColor == Themes.FirstPlayer && ThirdFloor[2, 1].BackColor == ThirdFloor[2, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (ThirdFloor[2, 1].BackColor == Themes.FirstPlayer && ThirdFloor[2, 1].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }

            // Rows
            if (ThirdFloor[1, 0].BackColor == Themes.FirstPlayer && ThirdFloor[1, 0].BackColor == ThirdFloor[0, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[2, 0].BackColor == Themes.BoardColor)
                    AI(2, 0);
            }

                if (ThirdFloor[1, 0].BackColor == Themes.FirstPlayer && ThirdFloor[1, 0].BackColor == ThirdFloor[2, 0].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[0, 1].BackColor && hisTurn == true)
            {
                if (ThirdFloor[2, 1].BackColor == Themes.BoardColor)
                    AI(2, 1);
            }

                if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[2, 1].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[0, 1].BackColor == Themes.BoardColor)
                        AI(0, 1);
                }
            
            if (ThirdFloor[1, 2].BackColor == Themes.FirstPlayer && ThirdFloor[1, 2].BackColor == ThirdFloor[0, 2].BackColor && hisTurn == true)
            {
                if (ThirdFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (ThirdFloor[1, 2].BackColor == Themes.FirstPlayer && ThirdFloor[1, 2].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[0, 2].BackColor == Themes.BoardColor)
                        AI(0, 2);
                }

            // Diagonal
            if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[0, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[2, 0].BackColor && hisTurn == true)
            {
                if (ThirdFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (ThirdFloor[1, 1].BackColor == Themes.FirstPlayer && ThirdFloor[1, 1].BackColor == ThirdFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (ThirdFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }