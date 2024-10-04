export interface ThemeComplement {
    id: number;
    themeId: number;
    complements: string;
}

export class ThemeComplement {
    constructor(
        public id: number,
        public themeId: number,
        public complements: string
    ) {}
}