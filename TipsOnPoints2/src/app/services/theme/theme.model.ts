export interface Theme {
    // Define the properties of the Theme object
    name: string;
    description: string;
    // Add other properties as needed
}

export class Theme {
    constructor(
        public name: string,
        public description: string,
    ) {}
}