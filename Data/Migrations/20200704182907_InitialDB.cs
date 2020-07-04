using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieShareCore.Data.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Admin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Birthdate = table.Column<DateTime>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Knowfor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Director = table.Column<string>(maxLength: 50, nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    Budget = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "AF", "Afghanistan" },
                    { 160, "NI", "Nicaragua" },
                    { 161, "NE", "Niger" },
                    { 162, "NG", "Nigeria" },
                    { 163, "NU", "Niue" },
                    { 164, "NF", "Norfolk Island" },
                    { 165, "MP", "Northern Mariana Islands" },
                    { 166, "NO", "Norway" },
                    { 167, "OM", "Oman" },
                    { 168, "PK", "Pakistan" },
                    { 169, "PW", "Palau" },
                    { 170, "PS", "Palestinian Territory, Occupied" },
                    { 171, "PA", "Panama" },
                    { 172, "PG", "Papua New Guinea" },
                    { 173, "PY", "Paraguay" },
                    { 174, "PE", "Peru" },
                    { 175, "PH", "Philippines" },
                    { 176, "PN", "Pitcairn" },
                    { 177, "PL", "Poland" },
                    { 178, "PT", "Portugal" },
                    { 179, "PR", "Puerto Rico" },
                    { 180, "QA", "Qatar" },
                    { 181, "RE", "Réunion" },
                    { 182, "RO", "Romania" },
                    { 183, "RU", "Russian Federation" },
                    { 184, "RW", "Rwanda" },
                    { 185, "BL", "Saint Barthélemy" },
                    { 186, "SH", "Saint Helena, Ascension and Tristan da Cunha" },
                    { 159, "NZ", "New Zealand" },
                    { 187, "KN", "Saint Kitts and Nevis" },
                    { 158, "NC", "New Caledonia" },
                    { 156, "NP", "Nepal" },
                    { 128, "LI", "Liechtenstein" },
                    { 129, "LT", "Lithuania" },
                    { 130, "LU", "Luxembourg" },
                    { 131, "MO", "Macao" },
                    { 132, "MK", "Macedonia, the former Yugoslav Republic of" },
                    { 133, "MG", "Madagascar" },
                    { 134, "MW", "Malawi" },
                    { 135, "MY", "Malaysia" },
                    { 136, "MV", "Maldives" },
                    { 137, "ML", "Mali" },
                    { 138, "MT", "Malta" },
                    { 140, "MQ", "Martinique" },
                    { 141, "MR", "Mauritania" },
                    { 142, "MU", "Mauritius" },
                    { 143, "YT", "Mayotte" },
                    { 144, "MX", "Mexico" },
                    { 145, "FM", "Micronesia, Federated States of" },
                    { 146, "MD", "Moldova, Republic of" },
                    { 147, "MC", "Monaco" },
                    { 148, "MN", "Mongolia" },
                    { 149, "ME", "Montenegro" },
                    { 150, "MS", "Montserrat" },
                    { 151, "MA", "Morocco" },
                    { 152, "MZ", "Mozambique" },
                    { 153, "MM", "Myanmar" },
                    { 154, "NA", "Namibia" },
                    { 155, "NR", "Nauru" },
                    { 157, "NL", "Netherlands" },
                    { 188, "LC", "Saint Lucia" },
                    { 189, "MF", "Saint Martin (French part)" },
                    { 190, "PM", "Saint Pierre and Miquelon" },
                    { 223, "TG", "Togo" },
                    { 224, "TK", "Tokelau" },
                    { 225, "TO", "Tonga" },
                    { 226, "TT", "Trinidad and Tobago" },
                    { 227, "TN", "Tunisia" },
                    { 228, "TR", "Turkey" },
                    { 229, "TM", "Turkmenistan" },
                    { 230, "TC", "Turks and Caicos Islands" },
                    { 231, "TV", "Tuvalu" },
                    { 232, "UG", "Uganda" },
                    { 233, "UA", "Ukraine" },
                    { 234, "AE", "United Arab Emirates" },
                    { 235, "GB", "United Kingdom" },
                    { 236, "US", "United States" },
                    { 237, "UM", "United States Minor Outlying Islands" },
                    { 238, "UY", "Uruguay" },
                    { 239, "UZ", "Uzbekistan" },
                    { 240, "VU", "Vanuatu" },
                    { 241, "VE", "Venezuela, Bolivarian Republic of" },
                    { 242, "VN", "Viet Nam" },
                    { 243, "VG", "Virgin Islands, British" },
                    { 244, "VI", "Virgin Islands, U.S." },
                    { 245, "WF", "Wallis and Futuna" },
                    { 246, "EH", "Western Sahara" },
                    { 247, "YE", "Yemen" },
                    { 248, "ZM", "Zambia" },
                    { 249, "ZW", "Zimbabwe" },
                    { 222, "TL", "Timor-Leste" },
                    { 221, "TH", "Thailand" },
                    { 220, "TZ", "Tanzania, United Republic of" },
                    { 219, "TJ", "Tajikistan" },
                    { 191, "VC", "Saint Vincent and the Grenadines" },
                    { 192, "WS", "Samoa" },
                    { 193, "SM", "San Marino" },
                    { 194, "ST", "Sao Tome and Principe" },
                    { 195, "SA", "Saudi Arabia" },
                    { 196, "SN", "Senegal" },
                    { 197, "RS", "Serbia" },
                    { 198, "SC", "Seychelles" },
                    { 199, "SL", "Sierra Leone" },
                    { 200, "SG", "Singapore" },
                    { 201, "SX", "Sint Maarten (Dutch part)" },
                    { 202, "SK", "Slovakia" },
                    { 203, "SI", "Slovenia" },
                    { 127, "LY", "Libya" },
                    { 204, "SB", "Solomon Islands" },
                    { 206, "ZA", "South Africa" },
                    { 207, "GS", "South Georgia and the South Sandwich Islands" },
                    { 208, "SS", "South Sudan" },
                    { 209, "ES", "Spain" },
                    { 210, "LK", "Sri Lanka" },
                    { 211, "SD", "Sudan" },
                    { 212, "SR", "Suriname" },
                    { 213, "SJ", "Svalbard and Jan Mayen" },
                    { 214, "SZ", "Swaziland" },
                    { 215, "SE", "Sweden" },
                    { 216, "CH", "Switzerland" },
                    { 217, "SY", "Syrian Arab Republic" },
                    { 218, "TW", "Taiwan, Province of China" },
                    { 205, "SO", "Somalia" },
                    { 126, "LR", "Liberia" },
                    { 139, "MH", "Marshall Islands" },
                    { 124, "LB", "Lebanon" },
                    { 34, "BN", "Brunei Darussalam" },
                    { 35, "BG", "Bulgaria" },
                    { 36, "BF", "Burkina Faso" },
                    { 37, "BI", "Burundi" },
                    { 38, "KH", "Cambodia" },
                    { 39, "CM", "Cameroon" },
                    { 40, "CA", "Canada" },
                    { 41, "CV", "Cape Verde" },
                    { 42, "KY", "Cayman Islands" },
                    { 43, "CF", "Central African Republic" },
                    { 44, "TD", "Chad" },
                    { 45, "CL", "Chile" },
                    { 46, "CN", "China" },
                    { 47, "CX", "Christmas Island" },
                    { 48, "CC", "Cocos (Keeling) Islands" },
                    { 49, "CO", "Colombia" },
                    { 125, "LS", "Lesotho" },
                    { 51, "CG", "Congo" },
                    { 52, "CD", "Congo, the Democratic Republic of the" },
                    { 53, "CK", "Cook Islands" },
                    { 54, "CR", "Costa Rica" },
                    { 55, "CI", "Côte d'Ivoire" },
                    { 56, "HR", "Croatia" },
                    { 57, "CU", "Cuba" },
                    { 58, "CW", "Curaçao" },
                    { 59, "CY", "Cyprus" },
                    { 60, "CZ", "Czech Republic" },
                    { 33, "IO", "British Indian Ocean Territory" },
                    { 32, "BR", "Brazil" },
                    { 31, "BV", "Bouvet Island" },
                    { 30, "BW", "Botswana" },
                    { 2, "AX", "Åland Islands" },
                    { 3, "AL", "Albania" },
                    { 4, "DZ", "Algeria" },
                    { 5, "AS", "American Samoa" },
                    { 6, "AD", "Andorra" },
                    { 7, "AO", "Angola" },
                    { 8, "AI", "Anguilla" },
                    { 9, "AQ", "Antarctica" },
                    { 10, "AG", "Antigua and Barbuda" },
                    { 11, "AR", "Argentina" },
                    { 12, "AM", "Armenia" },
                    { 13, "AW", "Aruba" },
                    { 14, "AU", "Australia" },
                    { 61, "DK", "Denmark" },
                    { 15, "AT", "Austria" },
                    { 17, "BS", "Bahamas" },
                    { 18, "BH", "Bahrain" },
                    { 19, "BD", "Bangladesh" },
                    { 20, "BB", "Barbados" },
                    { 21, "BY", "Belarus" },
                    { 22, "BE", "Belgium" },
                    { 23, "BZ", "Belize" },
                    { 24, "BJ", "Benin" },
                    { 25, "BM", "Bermuda" },
                    { 26, "BT", "Bhutan" },
                    { 27, "BO", "Bolivia, Plurinational State of" },
                    { 28, "BQ", "Bonaire, Sint Eustatius and Saba" },
                    { 29, "BA", "Bosnia and Herzegovina" },
                    { 16, "AZ", "Azerbaijan" },
                    { 62, "DJ", "Djibouti" },
                    { 50, "KM", "Comoros" },
                    { 64, "DO", "Dominican Republic" },
                    { 97, "HM", "Heard Island and McDonald Islands" },
                    { 98, "VA", "Holy See (Vatican City State)" },
                    { 99, "HN", "Honduras" },
                    { 100, "HK", "Hong Kong" },
                    { 101, "HU", "Hungary" },
                    { 102, "IS", "Iceland" },
                    { 103, "IN", "India" },
                    { 104, "ID", "Indonesia" },
                    { 105, "IR", "Iran, Islamic Republic of" },
                    { 106, "IQ", "Iraq" },
                    { 107, "IE", "Ireland" },
                    { 63, "DM", "Dominica" },
                    { 109, "IL", "Israel" },
                    { 110, "IT", "Italy" },
                    { 111, "JM", "Jamaica" },
                    { 112, "JP", "Japan" },
                    { 113, "JE", "Jersey" },
                    { 114, "JO", "Jordan" },
                    { 115, "KZ", "Kazakhstan" },
                    { 116, "KE", "Kenya" },
                    { 117, "KI", "Kiribati" },
                    { 118, "KP", "Korea, Democratic People's Republic of" },
                    { 119, "KR", "Korea, Republic of" },
                    { 120, "KW", "Kuwait" },
                    { 121, "KG", "Kyrgyzstan" },
                    { 122, "LA", "Lao People's Democratic Republic" },
                    { 123, "LV", "Latvia" },
                    { 96, "HT", "Haiti" },
                    { 95, "GY", "Guyana" },
                    { 108, "IM", "Isle of Man" },
                    { 93, "GN", "Guinea" },
                    { 65, "EC", "Ecuador" },
                    { 94, "GW", "Guinea-Bissau" },
                    { 67, "SV", "El Salvador" },
                    { 68, "GQ", "Equatorial Guinea" },
                    { 69, "ER", "Eritrea" },
                    { 70, "EE", "Estonia" },
                    { 71, "ET", "Ethiopia" },
                    { 72, "FK", "Falkland Islands (Malvinas)" },
                    { 73, "FO", "Faroe Islands" },
                    { 74, "FJ", "Fiji" },
                    { 75, "FI", "Finland" },
                    { 76, "FR", "France" },
                    { 77, "GF", "French Guiana" },
                    { 78, "PF", "French Polynesia" },
                    { 66, "EG", "Egypt" },
                    { 80, "GA", "Gabon" },
                    { 92, "GG", "Guernsey" },
                    { 91, "GT", "Guatemala" },
                    { 90, "GU", "Guam" },
                    { 89, "GP", "Guadeloupe" },
                    { 79, "TF", "French Southern Territories" },
                    { 87, "GL", "Greenland" },
                    { 88, "GD", "Grenada" },
                    { 85, "GI", "Gibraltar" },
                    { 84, "GH", "Ghana" },
                    { 83, "DE", "Germany" },
                    { 82, "GE", "Georgia" },
                    { 81, "GM", "Gambia" },
                    { 86, "GR", "Greece" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Admin", "Birthdate", "Country", "Mail", "Name" },
                values: new object[,]
                {
                    { 2, true, new DateTime(2020, 7, 4, 19, 29, 6, 560, DateTimeKind.Local).AddTicks(8942), "Cuba", "mail1@sample.com", "Malanga Yuca Frita" },
                    { 6, true, new DateTime(2020, 7, 4, 19, 29, 6, 564, DateTimeKind.Local).AddTicks(2994), "Cuba", "mail2@sample.com", "Julio Pérez" },
                    { 7, true, new DateTime(2020, 7, 4, 19, 29, 6, 564, DateTimeKind.Local).AddTicks(3079), "Cuba", "mail3@sample.com", "Haliam Pérez" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Birthdate", "Country", "Knowfor", "Name" },
                values: new object[,]
                {
                    { 10, new DateTime(1928, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cuba", "Memorias del Subdesarrollo", "Tomás Gutierres Alea" },
                    { 4, new DateTime(1899, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "UK", "Psycho", "Alfred Hitchcock" },
                    { 6, new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "CUBA", "Marina", "Haliam Pérez" },
                    { 2, new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Schindler's List", "Steven Spielberg" },
                    { 3, new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Taxi Driver", "Martin Scorsese" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 18, "Thriller" },
                    { 17, "Sport" },
                    { 16, "SciFi" },
                    { 15, "Romance" },
                    { 14, "Mistery" },
                    { 13, "Musical" },
                    { 12, "Horror" },
                    { 11, "History" },
                    { 10, "FilmNoir" },
                    { 9, "Fantasy" },
                    { 7, "Documentary" },
                    { 6, "Crime" },
                    { 5, "Comedy" },
                    { 4, "Biography" },
                    { 3, "Animation" },
                    { 2, "Adventure" },
                    { 1, "Action" },
                    { 19, "War" },
                    { 8, "Drama" },
                    { 20, "Western" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Budget", "Country", "Director", "Duration", "GenreId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 6, 8000000, "USA", "Quentin Tarantino", 153, 1, new DateTime(1994, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pulp Fiction" },
                    { 8, 2500000, "USA", "Alfred Hitchcock", 128, 1, new DateTime(1958, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vertigo" },
                    { 10, 5000000, "JAPAN", "Akira Kurosawa", 207, 1, new DateTime(1954, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The seven Samurai" },
                    { 11, 15000000, "USA", "Alfonso Cuarón", 135, 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roma" },
                    { 5, 250000, "USA", "Charles Chaplin", 81, 9, new DateTime(1931, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "City Lights" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
