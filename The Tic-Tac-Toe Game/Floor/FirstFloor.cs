            // Columns
            if (FirstFloor[0, 1].BackColor == Themes.FirstPlayer && FirstFloor[0, 1].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (FirstFloor[0, 1].BackColor == Themes.FirstPlayer && FirstFloor[0, 1].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[1, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[1, 2].BackColor == Themes.BoardColor)
                    AI(1, 2);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[1, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[1, 0].BackColor == Themes.BoardColor)
                        AI(1, 0);
                }


            if (FirstFloor[2, 1].BackColor == Themes.FirstPlayer && FirstFloor[2, 1].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[2, 1].BackColor == Themes.FirstPlayer && FirstFloor[2, 1].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }

            // Rows
            if (FirstFloor[1, 0].BackColor == Themes.FirstPlayer && FirstFloor[1, 0].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                    AI(2, 0);
            }

                if (FirstFloor[1, 0].BackColor == Themes.FirstPlayer && FirstFloor[1, 0].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 1].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 1].BackColor == Themes.BoardColor)
                    AI(2, 1);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 1].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 1].BackColor == Themes.BoardColor)
                        AI(0, 1);
                }
            
            if (FirstFloor[1, 2].BackColor == Themes.FirstPlayer && FirstFloor[1, 2].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[1, 2].BackColor == Themes.FirstPlayer && FirstFloor[1, 2].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                        AI(0, 2);
                }

            // Diagonal
            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[2, 2].BackColor == Themes.BoardColor)
                    AI(2, 2);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[0, 0].BackColor == Themes.BoardColor)
                        AI(0, 0);
                }

            if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[2, 0].BackColor && hisTurn == true)
            {
                if (FirstFloor[0, 2].BackColor == Themes.BoardColor)
                    AI(0, 2);
            }

                if (FirstFloor[1, 1].BackColor == Themes.FirstPlayer && FirstFloor[1, 1].BackColor == FirstFloor[0, 2].BackColor && hisTurn == true)
                {
                    if (FirstFloor[2, 0].BackColor == Themes.BoardColor)
                        AI(2, 0);
                }