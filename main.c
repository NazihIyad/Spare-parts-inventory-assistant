#include <stdio.h>
#include <string.h>

int main() {
    char *inventory[] = {"hydraulic pump", "PLC module", "servo motor"};
    int size = 3;
    char input[100];

    printf("Hej. Welcome to the spare parts inventory!\n");

    while (1) {
        printf("Which part do you need? ");
        fgets(input, sizeof(input), stdin);

        int len = strlen(input);
        if (len > 0 && input[len - 1] == '\n') {
            input[len - 1] = '\0';
        }

        if (strcmp(input, "Do you actually have any parts?") == 0 ||
            strcmp(input, "Is there anything in stock at all?") == 0) {
            printf("We have %d part(s)!\n", size);
            for (int i = 0; i < size; i++) {
                printf("%s\n", inventory[i]);
            }
        }
        else if (strcmp(input, inventory[0]) == 0 ||
                strcmp(input, inventory[1]) == 0 ||
                strcmp(input, inventory[2]) == 0) {
            printf("I've got %s here for you 😊. Bye!\n", input);
            break; 
        }
        else {
            printf("I am afraid we don't have any %s in the inventory 😔\n", input);
        }
    }

    return 0;
}
