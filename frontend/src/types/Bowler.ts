export type Bowler = {
  bowlerId: number;
  bowlerName: string; // Assuming the backend combines the names
  teamName: string; // Directly accessing teamName without nesting
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
};
