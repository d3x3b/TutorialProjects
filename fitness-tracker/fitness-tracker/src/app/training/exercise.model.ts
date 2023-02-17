export interface Exercise{
    id: string;
    name: string;
    duration: number;
    calories: number;
    date?: Date;
    state?: 'completed' | 'cancelled' | 'started' | null;
}