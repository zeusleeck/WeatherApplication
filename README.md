# WeatherApplication
Weather Application using ASP .NET Core MVC Framework based on the following Database Table. Please note that the data presented here are sample data without any real world reference. 

Live Website link: https://weatherapplicationserver.azurewebsites.net/Weather 

City Table
|Id |	CityName    |
|---|-------------|
|1	| Singapore   |
|2	| Kuala Lumpur|
|3	| Bangalore   |
|4	| Colombo     |

Variable table
| Id  | Name        | Unit | Value | Timestamp                          | CityId |
| --- | ----------- | ---- | ----- | ---------------------------------- | ------ |
| 1   | Temperature | °C   | 20    | 2023-01-01 00:00:00.0000000 +00:00 | 1      |
| 2   | Temperature | °C   | 17.3  | 2023-01-02 00:00:00.0000000 +00:00 | 1      |
| 3   | Temperature | °C   | 13.5  | 2023-01-03 00:00:00.0000000 +00:00 | 1      |
| 4   | Temperature | °C   | 15.8  | 2023-01-04 00:00:00.0000000 +00:00 | 1      |
| 5   | Temperature | °F   | 50.18 | 2023-01-05 00:00:00.0000000 +00:00 | 1      |
| 6   | Temperature | °C   | 11.6  | 2023-01-06 00:00:00.0000000 +00:00 | 1      |
| 7   | Temperature | °C   | 12.8  | 2023-01-07 00:00:00.0000000 +00:00 | 1      |
| 8   | Temperature | °F   | 58.46 | 2023-01-08 00:00:00.0000000 +00:00 | 1      |
| 9   | Temperature | °C   | 18.6  | 2023-01-09 00:00:00.0000000 +00:00 | 1      |
| 10  | Temperature | °C   | 19.2  | 2023-01-10 00:00:00.0000000 +00:00 | 1      |
| 11  | Temperature | °F   | 70.52 | 2023-01-11 00:00:00.0000000 +00:00 | 1      |
| 12  | Temperature | °C   | 23.7  | 2023-01-12 00:00:00.0000000 +00:00 | 1      |
| 13  | Temperature | °C   | 27.5  | 2023-01-13 00:00:00.0000000 +00:00 | 1      |
| 14  | Temperature | °C   | 26.3  | 2023-01-14 00:00:00.0000000 +00:00 | 1      |
| 15  | Temperature | °C   | 22.3  | 2023-01-15 00:00:00.0000000 +00:00 | 1      |
| 16  | Temperature | °C   | 25.7  | 2023-01-16 00:00:00.0000000 +00:00 | 1      |
| 17  | Temperature | °C   | 27.9  | 2023-01-17 00:00:00.0000000 +00:00 | 1      |
| 18  | Temperature | °C   | 30.4  | 2023-01-18 00:00:00.0000000 +00:00 | 1      |
| 19  | Temperature | °C   | 32.6  | 2023-01-19 00:00:00.0000000 +00:00 | 1      |
| 20  | Temperature | °C   | 33.7  | 2023-01-20 00:00:00.0000000 +00:00 | 1      |
| 21  | Temperature | °C   | 35.8  | 2023-01-21 00:00:00.0000000 +00:00 | 1      |
| 22  | Temperature | °C   | 38.1  | 2023-01-22 00:00:00.0000000 +00:00 | 1      |
| 23  | Temperature | °C   | 38.5  | 2023-01-23 00:00:00.0000000 +00:00 | 1      |
| 24  | Temperature | °C   | 36.3  | 2023-01-24 00:00:00.0000000 +00:00 | 1      |
| 25  | Temperature | °C   | 33.1  | 2023-01-25 00:00:00.0000000 +00:00 | 1      |
| 26  | Temperature | °C   | 31.7  | 2023-01-26 00:00:00.0000000 +00:00 | 1      |
| 27  | Temperature | °C   | 29.8  | 2023-01-27 00:00:00.0000000 +00:00 | 1      |
| 28  | Temperature | °C   | 26.7  | 2023-01-28 00:00:00.0000000 +00:00 | 1      |
| 29  | Temperature | °C   | 25.6  | 2023-01-29 00:00:00.0000000 +00:00 | 1      |
| 30  | Temperature | °C   | 26.2  | 2023-01-30 00:00:00.0000000 +00:00 | 1      |
| 31  | Temperature | °C   | 24.2  | 2023-01-31 00:00:00.0000000 +00:00 | 1      |
| 32  | Humidity    | %    | 65    | 2023-01-01 00:00:00.0000000 +00:00 | 1      |
| 33  | Humidity    | %    | 79.2  | 2023-01-02 00:00:00.0000000 +00:00 | 1      |
| 34  | Humidity    | %    | 80.5  | 2023-01-03 00:00:00.0000000 +00:00 | 1      |
| 35  | Humidity    | %    | 72.8  | 2023-01-04 00:00:00.0000000 +00:00 | 1      |
| 36  | Humidity    | %    | 70.1  | 2023-01-05 00:00:00.0000000 +00:00 | 1      |
| 37  | Humidity    | %    | 55.6  | 2023-01-06 00:00:00.0000000 +00:00 | 1      |
| 38  | Humidity    | %    | 57.8  | 2023-01-07 00:00:00.0000000 +00:00 | 1      |
| 39  | Humidity    | %    | 81.7  | 2023-01-08 00:00:00.0000000 +00:00 | 1      |
| 40  | Humidity    | %    | 69.6  | 2023-01-09 00:00:00.0000000 +00:00 | 1      |
| 41  | Humidity    | %    | 67.2  | 2023-01-10 00:00:00.0000000 +00:00 | 1      |
| 42  | Humidity    | %    | 62.4  | 2023-01-11 00:00:00.0000000 +00:00 | 1      |
| 43  | Humidity    | %    | 55.7  | 2023-01-12 00:00:00.0000000 +00:00 | 1      |
| 44  | Humidity    | %    | 53.5  | 2023-01-13 00:00:00.0000000 +00:00 | 1      |
| 45  | Humidity    | %    | 57.3  | 2023-01-14 00:00:00.0000000 +00:00 | 1      |
| 46  | Humidity    | %    | 52.3  | 2023-01-15 00:00:00.0000000 +00:00 | 1      |
| 47  | Humidity    | %    | 47.7  | 2023-01-16 00:00:00.0000000 +00:00 | 1      |
| 48  | Humidity    | %    | 53.9  | 2023-01-17 00:00:00.0000000 +00:00 | 1      |
| 49  | Humidity    | %    | 59.4  | 2023-01-18 00:00:00.0000000 +00:00 | 1      |
| 50  | Humidity    | %    | 65.6  | 2023-01-19 00:00:00.0000000 +00:00 | 1      |
| 51  | Humidity    | %    | 64.7  | 2023-01-20 00:00:00.0000000 +00:00 | 1      |
| 52  | Humidity    | %    | 62.8  | 2023-01-21 00:00:00.0000000 +00:00 | 1      |
| 53  | Humidity    | %    | 58.1  | 2023-01-22 00:00:00.0000000 +00:00 | 1      |
| 54  | Humidity    | %    | 71.5  | 2023-01-23 00:00:00.0000000 +00:00 | 1      |
| 55  | Humidity    | %    | 73.3  | 2023-01-24 00:00:00.0000000 +00:00 | 1      |
| 56  | Humidity    | %    | 69.1  | 2023-01-25 00:00:00.0000000 +00:00 | 1      |
| 57  | Humidity    | %    | 79.7  | 2023-01-26 00:00:00.0000000 +00:00 | 1      |
| 58  | Humidity    | %    | 76.8  | 2023-01-27 00:00:00.0000000 +00:00 | 1      |
| 59  | Humidity    | %    | 81.7  | 2023-01-28 00:00:00.0000000 +00:00 | 1      |
| 60  | Humidity    | %    | 72.6  | 2023-01-29 00:00:00.0000000 +00:00 | 1      |
| 61  | Humidity    | %    | 66.2  | 2023-01-30 00:00:00.0000000 +00:00 | 1      |
| 62  | Humidity    | %    | 64.2  | 2023-01-31 00:00:00.0000000 +00:00 | 1      |
| 63  | Temperature | °C   | 36.3  | 2023-01-01 00:00:00.0000000 +00:00 | 2      |
| 64  | Temperature | °C   | 37.6  | 2023-01-02 00:00:00.0000000 +00:00 | 2      |
| 65  | Temperature | °C   | 36.2  | 2023-01-03 00:00:00.0000000 +00:00 | 2      |
| 66  | Temperature | °C   | 32.4  | 2023-01-04 00:00:00.0000000 +00:00 | 2      |
| 67  | Temperature | °C   | 34.6  | 2023-01-05 00:00:00.0000000 +00:00 | 2      |
| 68  | Temperature | °C   | 32.4  | 2023-01-06 00:00:00.0000000 +00:00 | 2      |
| 69  | Temperature | °C   | 33.7  | 2023-01-07 00:00:00.0000000 +00:00 | 2      |
| 70  | Temperature | °C   | 35.4  | 2023-01-08 00:00:00.0000000 +00:00 | 2      |
| 71  | Temperature | °C   | 36.2  | 2023-01-09 00:00:00.0000000 +00:00 | 2      |
| 72  | Temperature | °C   | 33.4  | 2023-01-10 00:00:00.0000000 +00:00 | 2      |
| 73  | Temperature | °C   | 31.8  | 2023-01-11 00:00:00.0000000 +00:00 | 2      |
| 74  | Temperature | °C   | 29.9  | 2023-01-12 00:00:00.0000000 +00:00 | 2      |
| 75  | Temperature | °C   | 26.5  | 2023-01-13 00:00:00.0000000 +00:00 | 2      |
| 76  | Temperature | °C   | 25.3  | 2023-01-14 00:00:00.0000000 +00:00 | 2      |
| 77  | Temperature | °C   | 26.3  | 2023-01-15 00:00:00.0000000 +00:00 | 2      |
| 78  | Temperature | °C   | 24.8  | 2023-01-16 00:00:00.0000000 +00:00 | 2      |
| 79  | Temperature | °C   | 20.7  | 2023-01-17 00:00:00.0000000 +00:00 | 2      |
| 80  | Temperature | °F   | 63.68 | 2023-01-18 00:00:00.0000000 +00:00 | 2      |
| 81  | Temperature | °C   | 13.9  | 2023-01-19 00:00:00.0000000 +00:00 | 2      |
| 82  | Temperature | °C   | 15.3  | 2023-01-20 00:00:00.0000000 +00:00 | 2      |
| 83  | Temperature | °C   | 10.2  | 2023-01-21 00:00:00.0000000 +00:00 | 2      |
| 84  | Temperature | °C   | 11.8  | 2023-01-22 00:00:00.0000000 +00:00 | 2      |
| 85  | Temperature | °C   | 12.6  | 2023-01-23 00:00:00.0000000 +00:00 | 2      |
| 86  | Temperature | °C   | 14.2  | 2023-01-24 00:00:00.0000000 +00:00 | 2      |
| 87  | Temperature | °C   | 18.3  | 2023-01-25 00:00:00.0000000 +00:00 | 2      |
| 88  | Temperature | °C   | 19.6  | 2023-01-26 00:00:00.0000000 +00:00 | 2      |
| 89  | Temperature | °C   | 21.7  | 2023-01-27 00:00:00.0000000 +00:00 | 2      |
| 90  | Temperature | °C   | 23.7  | 2023-01-28 00:00:00.0000000 +00:00 | 2      |
| 91  | Temperature | °C   | 27.5  | 2023-01-29 00:00:00.0000000 +00:00 | 2      |
| 92  | Temperature | °F   | 86    | 2023-01-30 00:00:00.0000000 +00:00 | 2      |
| 93  | Temperature | °C   | 30.1  | 2023-01-31 00:00:00.0000000 +00:00 | 2      |
| 94  | Humidity    | %    | 71.6  | 2023-01-01 00:00:00.0000000 +00:00 | 2      |
| 95  | Humidity    | %    | 73.2  | 2023-01-02 00:00:00.0000000 +00:00 | 2      |
| 96  | Humidity    | %    | 69.6  | 2023-01-03 00:00:00.0000000 +00:00 | 2      |
| 97  | Humidity    | %    | 79.5  | 2023-01-04 00:00:00.0000000 +00:00 | 2      |
| 98  | Humidity    | %    | 76.6  | 2023-01-05 00:00:00.0000000 +00:00 | 2      |
| 99  | Humidity    | %    | 81.8  | 2023-01-06 00:00:00.0000000 +00:00 | 2      |
| 100 | Humidity    | %    | 72.3  | 2023-01-07 00:00:00.0000000 +00:00 | 2      |
| 101 | Humidity    | %    | 72.2  | 2023-01-08 00:00:00.0000000 +00:00 | 2      |
| 102 | Humidity    | %    | 70.7  | 2023-01-09 00:00:00.0000000 +00:00 | 2      |
| 103 | Humidity    | %    | 65.9  | 2023-01-10 00:00:00.0000000 +00:00 | 2      |
| 104 | Humidity    | %    | 67.5  | 2023-01-11 00:00:00.0000000 +00:00 | 2      |
| 105 | Humidity    | %    | 55.3  | 2023-01-12 00:00:00.0000000 +00:00 | 2      |
| 106 | Humidity    | %    | 47.7  | 2023-01-13 00:00:00.0000000 +00:00 | 2      |
| 107 | Humidity    | %    | 53.9  | 2023-01-14 00:00:00.0000000 +00:00 | 2      |
| 108 | Humidity    | %    | 59.3  | 2023-01-15 00:00:00.0000000 +00:00 | 2      |
| 109 | Humidity    | %    | 67.7  | 2023-01-16 00:00:00.0000000 +00:00 | 2      |
| 110 | Humidity    | %    | 81.4  | 2023-01-17 00:00:00.0000000 +00:00 | 2      |
| 111 | Humidity    | %    | 61.3  | 2023-01-18 00:00:00.0000000 +00:00 | 2      |
| 112 | Humidity    | %    | 54.6  | 2023-01-19 00:00:00.0000000 +00:00 | 2      |
| 113 | Humidity    | %    | 65.8  | 2023-01-20 00:00:00.0000000 +00:00 | 2      |
| 114 | Humidity    | %    | 79.7  | 2023-01-21 00:00:00.0000000 +00:00 | 2      |
| 115 | Humidity    | %    | 80.2  | 2023-01-22 00:00:00.0000000 +00:00 | 2      |
| 116 | Humidity    | %    | 69.1  | 2023-01-23 00:00:00.0000000 +00:00 | 2      |
| 117 | Humidity    | %    | 67.7  | 2023-01-24 00:00:00.0000000 +00:00 | 2      |
| 118 | Humidity    | %    | 62.9  | 2023-01-25 00:00:00.0000000 +00:00 | 2      |
| 119 | Humidity    | %    | 45.4  | 2023-01-26 00:00:00.0000000 +00:00 | 2      |
| 120 | Humidity    | %    | 53.9  | 2023-01-27 00:00:00.0000000 +00:00 | 2      |
| 121 | Humidity    | %    | 45.2  | 2023-01-28 00:00:00.0000000 +00:00 | 2      |
| 122 | Humidity    | %    | 54.1  | 2023-01-29 00:00:00.0000000 +00:00 | 2      |
| 123 | Humidity    | %    | 52.5  | 2023-01-30 00:00:00.0000000 +00:00 | 2      |
| 124 | Humidity    | %    | 58.8  | 2023-01-31 00:00:00.0000000 +00:00 | 2      |
| 125 | Temperature | °C   | 31.7  | 2023-01-01 00:00:00.0000000 +00:00 | 3      |
| 126 | Temperature | °C   | 34.4  | 2023-01-02 00:00:00.0000000 +00:00 | 3      |
| 127 | Temperature | °C   | 37.2  | 2023-01-03 00:00:00.0000000 +00:00 | 3      |
| 128 | Temperature | °C   | 29.4  | 2023-01-04 00:00:00.0000000 +00:00 | 3      |
| 129 | Temperature | °C   | 31.8  | 2023-01-05 00:00:00.0000000 +00:00 | 3      |
| 130 | Temperature | °C   | 27.9  | 2023-01-06 00:00:00.0000000 +00:00 | 3      |
| 131 | Temperature | °C   | 26.5  | 2023-01-07 00:00:00.0000000 +00:00 | 3      |
| 132 | Temperature | °F   | 77.54 | 2023-01-08 00:00:00.0000000 +00:00 | 3      |
| 133 | Temperature | °C   | 31.3  | 2023-01-09 00:00:00.0000000 +00:00 | 3      |
| 134 | Temperature | °C   | 33.6  | 2023-01-10 00:00:00.0000000 +00:00 | 3      |
| 135 | Temperature | °C   | 36.2  | 2023-01-11 00:00:00.0000000 +00:00 | 3      |
| 136 | Temperature | °C   | 32.4  | 2023-01-12 00:00:00.0000000 +00:00 | 3      |
| 137 | Temperature | °C   | 28.6  | 2023-01-13 00:00:00.0000000 +00:00 | 3      |
| 138 | Temperature | °C   | 23.9  | 2023-01-14 00:00:00.0000000 +00:00 | 3      |
| 139 | Temperature | °C   | 21.3  | 2023-01-15 00:00:00.0000000 +00:00 | 3      |
| 140 | Temperature | °C   | 19.2  | 2023-01-16 00:00:00.0000000 +00:00 | 3      |
| 141 | Temperature | °C   | 13.8  | 2023-01-17 00:00:00.0000000 +00:00 | 3      |
| 142 | Temperature | °C   | 12.6  | 2023-01-18 00:00:00.0000000 +00:00 | 3      |
| 143 | Temperature | °C   | 14.2  | 2023-01-19 00:00:00.0000000 +00:00 | 3      |
| 144 | Temperature | °F   | 64.94 | 2023-01-20 00:00:00.0000000 +00:00 | 3      |
| 145 | Temperature | °C   | 17.6  | 2023-01-21 00:00:00.0000000 +00:00 | 3      |
| 146 | Temperature | °C   | 19.7  | 2023-01-22 00:00:00.0000000 +00:00 | 3      |
| 147 | Temperature | °C   | 27.7  | 2023-01-23 00:00:00.0000000 +00:00 | 3      |
| 148 | Temperature | °C   | 31.6  | 2023-01-24 00:00:00.0000000 +00:00 | 3      |
| 149 | Temperature | °C   | 32.4  | 2023-01-25 00:00:00.0000000 +00:00 | 3      |
| 150 | Temperature | °C   | 27.3  | 2023-01-26 00:00:00.0000000 +00:00 | 3      |
| 151 | Temperature | °C   | 24.8  | 2023-01-27 00:00:00.0000000 +00:00 | 3      |
| 152 | Temperature | °C   | 23.7  | 2023-01-28 00:00:00.0000000 +00:00 | 3      |
| 153 | Temperature | °C   | 29.5  | 2023-01-29 00:00:00.0000000 +00:00 | 3      |
| 154 | Temperature | °C   | 26    | 2023-01-30 00:00:00.0000000 +00:00 | 3      |
| 155 | Temperature | °C   | 24.1  | 2023-01-31 00:00:00.0000000 +00:00 | 3      |
| 156 | Humidity    | %    | 49.1  | 2023-01-01 00:00:00.0000000 +00:00 | 3      |
| 157 | Humidity    | %    | 52.5  | 2023-01-02 00:00:00.0000000 +00:00 | 3      |
| 158 | Humidity    | %    | 53.9  | 2023-01-03 00:00:00.0000000 +00:00 | 3      |
| 159 | Humidity    | %    | 62.2  | 2023-01-04 00:00:00.0000000 +00:00 | 3      |
| 160 | Humidity    | %    | 52.5  | 2023-01-05 00:00:00.0000000 +00:00 | 3      |
| 161 | Humidity    | %    | 58.9  | 2023-01-06 00:00:00.0000000 +00:00 | 3      |
| 162 | Humidity    | %    | 71.3  | 2023-01-07 00:00:00.0000000 +00:00 | 3      |
| 163 | Humidity    | %    | 73.7  | 2023-01-08 00:00:00.0000000 +00:00 | 3      |
| 164 | Humidity    | %    | 69.4  | 2023-01-09 00:00:00.0000000 +00:00 | 3      |
| 165 | Humidity    | %    | 78.6  | 2023-01-10 00:00:00.0000000 +00:00 | 3      |
| 166 | Humidity    | %    | 77.9  | 2023-01-11 00:00:00.0000000 +00:00 | 3      |
| 167 | Humidity    | %    | 55    | 2023-01-12 00:00:00.0000000 +00:00 | 3      |
| 168 | Humidity    | %    | 43.1  | 2023-01-13 00:00:00.0000000 +00:00 | 3      |
| 169 | Humidity    | %    | 45.2  | 2023-01-14 00:00:00.0000000 +00:00 | 3      |
| 170 | Humidity    | %    | 67.7  | 2023-01-15 00:00:00.0000000 +00:00 | 3      |
| 171 | Humidity    | %    | 71.3  | 2023-01-16 00:00:00.0000000 +00:00 | 3      |
| 172 | Humidity    | %    | 82.9  | 2023-01-17 00:00:00.0000000 +00:00 | 3      |
| 173 | Humidity    | %    | 76.5  | 2023-01-18 00:00:00.0000000 +00:00 | 3      |
| 174 | Humidity    | %    | 71.9  | 2023-01-19 00:00:00.0000000 +00:00 | 3      |
| 175 | Humidity    | %    | 65.1  | 2023-01-20 00:00:00.0000000 +00:00 | 3      |
| 176 | Humidity    | %    | 67.6  | 2023-01-21 00:00:00.0000000 +00:00 | 3      |
| 177 | Humidity    | %    | 81.9  | 2023-01-22 00:00:00.0000000 +00:00 | 3      |
| 178 | Humidity    | %    | 61.4  | 2023-01-23 00:00:00.0000000 +00:00 | 3      |
| 179 | Humidity    | %    | 54.2  | 2023-01-24 00:00:00.0000000 +00:00 | 3      |
| 180 | Humidity    | %    | 65.8  | 2023-01-25 00:00:00.0000000 +00:00 | 3      |
| 181 | Humidity    | %    | 78.9  | 2023-01-26 00:00:00.0000000 +00:00 | 3      |
| 182 | Humidity    | %    | 81.1  | 2023-01-27 00:00:00.0000000 +00:00 | 3      |
| 183 | Humidity    | %    | 69.4  | 2023-01-28 00:00:00.0000000 +00:00 | 3      |
| 184 | Humidity    | %    | 55.8  | 2023-01-29 00:00:00.0000000 +00:00 | 3      |
| 185 | Humidity    | %    | 47.9  | 2023-01-30 00:00:00.0000000 +00:00 | 3      |
| 186 | Humidity    | %    | 53.3  | 2023-01-31 00:00:00.0000000 +00:00 | 3      |
