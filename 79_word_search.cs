public class Solution {
    public bool Exist(char[][] board, string word) 
    {
        int rows = board.Length;
        int cols  = board[0].Length;

        for(int i =0;i< rows;i++)
        {
            for(int j=0;j<cols;j++)
            {
                if (board[i][j] == word[0] && Exists(board,word,0, i, j)) 
                    return true;
            }
        }
        return false;
    }

     bool Exists(char[][] board, string word,int index,int row,int col)
     {
        if(index == word.Length)
        {
            return true;
        }

        if(row < 0 || row >= board.Length || col < 0 || col >= board[0].Length )
        {
            return false;
        }
         if(board[row][col]!= word[index])
        {
            return false;
        }
        char temp = board[row][col];
        board[row][col] = ' ';
        var left =  Exists(board,word,index+1,row,col-1);
        var right = Exists(board,word,index+1,row,col+1);
        var up = Exists(board,word,index+1,row-1,col);
        var down = Exists(board,word,index+1,row+1,col);
        bool isExist = left | right | up | down;
        board[row][col] = temp;
        return isExist;

     }
}