#include <iostream>
#include <fstream>
#include <vector>
#include <cmath>
#include <list>


using namespace std;

// height and width of grid
// global var
const int HEIGHT =  20;
const int WIDTH =  20;

// x and y position of starting point
// global var
int STARTING_X = 0;
int STARTING_Y = 0;

// x and y position of ending point
// global var
int ENDING_X = 19;
int ENDING_Y = 19;

// Possible moves (order as in pdf file)
const int moves[][2] = {
        { 0, 1 },   // up
        { 0, -1 },  // down
        { -1, 0 },  // left
        {1, 0}      // right
};

//main heuristic equazion in A*
double heuristic(int poz_x, int poz_y){
    return sqrt(pow((poz_x - ENDING_X),2) + pow((poz_y - ENDING_Y),2));
}

// main class for all Nodes
class Node{
public:
    int x, y;       // x, y position
    Node* last;     // parent node
    double g;       // how far from starting node (10 if one block away)
    double h;       // (heuristic) how far from end node

    Node(int x, int y, Node* last, double g, double h): x(x),y(y),last(last),g(g),h(h) {};

    // cost of moving (the lower the better)
    double f_cost() const{
        return g+h;
    }
};

// to do
void flipping_nodes(Node point, int n){
    int temp = point.x;
    point.x = n - 1 - point.y;
    point.y = temp;
};

int main() {
    //setting txt matrix into tab
    vector<vector<int>> grid;
    ifstream iFile;
    iFile.open("D:/CODE/cpp/grid.txt");
    for(int i=0; i<HEIGHT; i++){
        for(int j=0; j<WIDTH; j++){
            iFile >> grid[i][j];
        }
    }
    iFile.close();

    // CHECKING IF STARTING POINT IS WALL - IF SO END
    if (grid[STARTING_X][STARTING_Y] == 5){
        cout << "Wall is starting point. Error!" << endl;
        //printing original grid
        for(int i=0; i<HEIGHT; i++){
            for(int j=0; j<WIDTH; j++){
                cout << grid[i][j];
                cout << ' ';
            }
            cout << "\n";
        }
        return 0;
    }

    //making main two arrays
    list<Node*> OPEN;      //the set of nodes to be evaluated
    list<Node*> CLOSED;    //the set of nodes already evaluated

    // starting point
    Node *starting_node = new Node(STARTING_X,STARTING_Y, nullptr, 0, heuristic(STARTING_X, STARTING_Y));

    flipping_nodes(*starting_node, HEIGHT);

    // !STARTING A_STAR! //
    OPEN.push_back(starting_node);
    while(!OPEN.empty()){
        Node *curr = OPEN.front();

        for (Node *node : OPEN)
        {
            /*

            WYBIERANIE CHYBA KTORY JEST NAJMNIEJSZY
            TO DOO
            |
            |
            V

             */
            if ( (node->f_cost() == curr->f_cost() && rand() % 2 == 0) || node->f_cost() < curr->f_cost())
                curr = node;
        }

        OPEN.remove(curr);
        CLOSED.push_back(curr);

        if (curr->x == ENDING_X && curr->y == ENDING_Y){
            while(curr != NULL){
                grid[curr->x][curr->y] = 3;
                curr = curr -> last;
            }
            break;
        };

        // ----------------------------------------------------------------------------------------------------------------------------------------------------------------

        for(int i = 0; i < 4; ++i) {
            int new_x = curr->x + moves[i][0];
            int new_y = curr->y + moves[i][1];

            // Checker if the new position is in the grid bounds
            if (new_x >= 0 && new_x < WIDTH && new_y >= 0 && new_y < HEIGHT) {
                // Checker if the new position is not a wall (1)
                if (grid[new_x][new_y] != 1) {
                    // Checker if the new position is not in the CLOSED list
                    bool inClosed = false;
                    for (Node *closedNode : CLOSED) {
                        if (closedNode->x == new_x && closedNode->y == new_y) {
                            inClosed = true;
                            break;
                        }
                    }

                    if (!inClosed) {
                        // Create a new neighbor and add it to the neighbors list
                        double g = curr->g + 1;
                        double h = heuristic(new_x, new_y);
                        Node *neighbor = new Node(new_x, new_y, curr, g, h);
                        OPEN.push_back(neighbor);
                    }
                }
            }
        }
    };

    // printing grid with A_star implemented
    for(int i=0; i<HEIGHT; i++){
        for(int j=0; j<WIDTH; j++){
            cout << grid[i][j];
            cout << ' ';
        }
        cout << "\n";
    }

    return 0;
}
