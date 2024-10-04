import { ThemeComplement } from "./themecomplement.model"; 

export interface Theme {
    id: number;
    pluralTheme: string;
    singleTheme: string;
    qtyTips: number;
    themeComplements: ThemeComplement[];
}

export class Theme {
    constructor(
        public id: number,
        public pluralTheme: string,
        public singleTheme: string,
        public qtyTips: number,
        public themeComplements: ThemeComplement[] = []
    ) {}
}