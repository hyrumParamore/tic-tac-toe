
def main():
    # player = next_player("")
    board = create_board()
    # while not (has_winner(board) or is_a_draw(board)):
        # display_board(board)
        # make_move(player, board)
        # player = next_player(player)
    display_board(board)
    print("Good game. Thanks for playing!") 


def create_board():
    # This creates the list where the values are stored
    board = []
    for square in range(9):
        board.append(square + 1)
    return board

def display_board(board):
    print()
    # Board is the list and the number is the index
    print(f"{board[0]}|{board[1]}|{board[2]}")
    print('-+-+-')
    print(f"{board[3]}|{board[4]}|{board[5]}")
    print('-+-+-')
    print(f"{board[6]}|{board[7]}|{board[8]}")
    print()






if __name__ == "__main__":
    main()