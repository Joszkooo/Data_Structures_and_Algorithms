/*|---------------------------------|
 *|     Made by Michał Jodko        |
 *|    Feel free to be inspired :)  |
 *|             ©2024               |
 *|---------------------------------|
 */
#include <iostream>
#include <fstream>
#include <vector>
#include <cmath>
#include <algorithm>
#include <queue>
#include <list>

using namespace std;

// height and width of grid
// global var
const int HEIGHT = 20;
const int WIDTH = 20;

// x and y position of starting point
// global var
int STARTING_X = 0;
int STARTING_Y = 0;

// x and y position of ending point
// global var
int ENDING_X = 19;
int ENDING_Y = 19;

// possible moves (order as in pdf file)
const int moves[][2] = {
        {0, 1},   // up
        {0, -1},  // down
        {-1, 0},  // left
        {1, 0}    // right
};

//main heuristic equazion in A*
double heuristic(int poz_x, int poz_y) {
    return sqrt(pow((poz_x - ENDING_X), 2) + pow((poz_y - ENDING_Y), 2));
}

// main class for all Nodes
class Node {
public:
    int x, y;       // x, y position
    Node* last;     // parent node
    double g;       // how far from starting node (10 if one block away)
    double h;       // (heuristic) how far from end node

    Node(int x, int y, Node *last, double g, double h) : x(x), y(y), last(last), g(g), h(h) {}

    // cost of moving (the lower the better)
    double f_cost() const {
        return g + h;
    }
};

// comparing f_cost of two nodes
class Compare {
public:
    bool operator() (Node* a, Node* b){
        return a->f_cost() > b->f_cost();
    }
};

// flipping so 0,0 node is in left corner and 19,19 is in upper right corner
void flipping_nodes(Node* point) {
    int temp = point->x;
    point->x = HEIGHT - 1 - point->y;
    point->y = temp;
}

// checking if new possible node is blank space (not wall) + if new x and y are in grid bounds
bool is_free_and_in_bounds(int x, int y, int grid[HEIGHT][WIDTH]){
    return x >= 0 && x < WIDTH && y < HEIGHT && y >= 0 && grid[x][y] == 0;
}

// checks if new possible node is in list
bool list_checker(list<Node*> l, int x, int y){
    for(Node* node: l){
        if(node->x == x && node->y == y)
            return true;
    }
    return false;
}

int main() {
    //setting txt matrix into array
    int grid[HEIGHT][WIDTH];
    ifstream iFile;
    iFile.open("grid.txt");
    for (int i = 0; i < HEIGHT; i++) {
        for (int j = 0; j < WIDTH; j++) {
            iFile >> grid[i][j];
        }
    }
    iFile.close();

    if(grid[STARTING_X][STARTING_Y] == 5 || grid[ENDING_X][ENDING_Y] == 5)
        cout<<"Punkt startowy lub koncowy to sciana";
    else{
        // flag to check if there is any possible path to the end
        // false - no path  |  true - path found
        bool flag = false;

        // making main two arrays
        priority_queue<Node*, vector<Node*>, Compare> OPEN;     //the set of nodes to be evaluated  (priority queue is to find the closest element using coparating class)
        list<Node*> CLOSED;                                     //the set of nodes already evaluated

        // making starting and ending node (ending node will only be used to check x and y coordinates - possible speed up, but it looks nicer :P)
        Node* starting_node = new Node(STARTING_X, STARTING_Y, nullptr, 0, 0);
        Node* ending_node = new Node(ENDING_X, ENDING_Y, nullptr, 0,0);
        flipping_nodes(starting_node);
        flipping_nodes(ending_node);

        // !STARTING A_STAR! //
        OPEN.push(starting_node);
        while (!OPEN.empty()) {
            // taking the neariest node (this with the lowest f_cost)
            Node* curr = OPEN.top();
            OPEN.pop();

            // checking if node is in closed, if yes -> take another node
            if(list_checker(CLOSED, curr->x, curr->y))
                continue;

            // if not in closed -> put it there
            CLOSED.push_back(curr);

            // ending node found - setting the path by going to parent and ending loop
            if (curr->x == ending_node->x && curr->y == ending_node->y) {
                while (curr != nullptr) {
                    grid[curr->x][curr->y] = 3;
                    curr = curr->last;
                }
                flag = true;
                break;
            }

            // checking all neighbours
            for (int i = 0; i < 4; ++i) {
                int new_x = curr->x + moves[i][0];
                int new_y = curr->y + moves[i][1];

                // checking if new possible node is in bounds and if it is not already in array
                if (is_free_and_in_bounds(new_x, new_y, grid) && !list_checker(CLOSED, new_x, new_y)) {

                    // if it is okay, calculate heuristic
                    // make new node and put it into OPEN queue
                    double g = curr->g + 1;
                    double h = heuristic(new_x, new_y);
                    Node* neighbor = new Node(new_x, new_y, curr, g, h);
                    OPEN.push(neighbor);
                }
            }
        }
        // checking flag and ending algorithm
        if(flag){
            cout<<"Znaleziono trase!:\n";
            for (int i = 0; i < HEIGHT; i++) {
                for (int j = 0; j < WIDTH; j++) {
                    cout << grid[i][j];
                    cout << ' ';
                }
                cout << "\n";
            }
        }
        else cout<<"Nie znaleziono trasy :((";
    }
    return 0;
}
