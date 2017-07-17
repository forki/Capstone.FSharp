﻿namespace Capstone.FSharp.X86

type AVXRoundingMode =
    | None = 0
    | Nearest = 1
    | Down = 2
    | Up = 3
    | Zero = 4

type AVXBroadcastKind =
    | None = 0
    | VBroadcast2 = 1
    | VBroadcast4 = 2
    | VBroadcast8 = 3
    | VBroadcast16 = 4

type SSEConditionCode = 
    | None = 0
    | EQ = 1
    | LT = 2
    | LE = 3
    | UNORD = 4
    | NEQ = 5
    | NLT = 6
    | NLE = 7
    | ORD = 8
    | EQ_UQ = 9
    | NGE = 10
    | NGT = 11
    | FALSE = 12
    | NEQ_OQ = 13
    | GE = 14
    | GT = 15
    | TRUE = 16

type AVXConditionCode = 
    | None = 0
    | EQ = 1
    | LT = 2
    | LE = 3
    | UNORD = 4
    | NEQ = 5
    | NLT = 6
    | NLE = 7
    | ORD = 8
    | EQ_UQ = 9
    | NGE = 10
    | NGT = 11
    | FALSE = 12
    | NEQ_OQ = 13
    | GE = 14
    | GT = 15
    | TRUE = 16
    | EQ_OS = 17
    | LT_OQ = 18
    | LE_OQ = 19
    | UNORD_S = 20
    | NEQ_US = 21
    | NLT_UQ = 22
    | NLE_UQ = 23
    | ORD_S = 24
    | EQ_US = 25
    | NGE_UQ = 26
    | NGT_UQ = 27
    | FALSE_OS = 28
    | NEQ_OS = 29
    | GE_OQ = 30
    | GT_OQ = 31
    | TRUE_US = 32

type Register = 
    | None = 0
    | AH = 1
    | AL = 2
    | AX = 3
    | BH = 4
    | BL = 5
    | BP = 6
    | BPL = 7
    | BX = 8
    | CH = 9
    | CL = 10
    | CS = 11
    | CX = 12
    | DH = 13
    | DI = 14
    | DIL = 15
    | DL = 16
    | DS = 17
    | DX = 18
    | EAX = 19
    | EBP = 20
    | EBX = 21
    | ECX = 22
    | EDI = 23
    | EDX = 24
    | EFLAGS = 25
    | EIP = 26
    | EIZ = 27
    | ES = 28
    | ESI = 29
    | ESP = 30
    | FPSW = 31
    | FS = 32
    | GS = 33
    | IP = 34
    | RAX = 35
    | RBP = 36
    | RBX = 37
    | RCX = 38
    | RDI = 39
    | RDX = 40
    | RIP = 41
    | RIZ = 42
    | RSI = 43
    | RSP = 44
    | SI = 45
    | SIL = 46
    | SP = 47
    | SPL = 48
    | SS = 49
    | CR0 = 50
    | CR1 = 51
    | CR2 = 52
    | CR3 = 53
    | CR4 = 54
    | CR5 = 55
    | CR6 = 56
    | CR7 = 57
    | CR8 = 58
    | CR9 = 59
    | CR10 = 60
    | CR11 = 61
    | CR12 = 62
    | CR13 = 63
    | CR14 = 64
    | CR15 = 65
    | DR0 = 66
    | DR1 = 67
    | DR2 = 68
    | DR3 = 69
    | DR4 = 70
    | DR5 = 71
    | DR6 = 72
    | DR7 = 73
    | FP0 = 74
    | FP1 = 75
    | FP2 = 76
    | FP3 = 77
    | FP4 = 78
    | FP5 = 79
    | FP6 = 80
    | FP7 = 81
    | K0 = 82
    | K1 = 83
    | K2 = 84
    | K3 = 85
    | K4 = 86
    | K5 = 87
    | K6 = 88
    | K7 = 89
    | MM0 = 90
    | MM1 = 91
    | MM2 = 92
    | MM3 = 93
    | MM4 = 94
    | MM5 = 95
    | MM6 = 96
    | MM7 = 97
    | R8 = 98
    | R9 = 99
    | R10 = 100
    | R11 = 101
    | R12 = 102
    | R13 = 103
    | R14 = 104
    | R15 = 105
    | ST0 = 106
    | ST1 = 107
    | ST2 = 108
    | ST3 = 109
    | ST4 = 110
    | ST5 = 111
    | ST6 = 112
    | ST7 = 113
    | XMM0 = 114
    | XMM1 = 115
    | XMM2 = 116
    | XMM3 = 117
    | XMM4 = 118
    | XMM5 = 119
    | XMM6 = 120
    | XMM7 = 121
    | XMM8 = 122
    | XMM9 = 123
    | XMM10 = 124
    | XMM11 = 125
    | XMM12 = 126
    | XMM13 = 127
    | XMM14 = 128
    | XMM15 = 129
    | XMM16 = 130
    | XMM17 = 131
    | XMM18 = 132
    | XMM19 = 133
    | XMM20 = 134
    | XMM21 = 135
    | XMM22 = 136
    | XMM23 = 137
    | XMM24 = 138
    | XMM25 = 139
    | XMM26 = 140
    | XMM27 = 141
    | XMM28 = 142
    | XMM29 = 143
    | XMM30 = 144
    | XMM31 = 145
    | YMM0 = 146
    | YMM1 = 147
    | YMM2 = 148
    | YMM3 = 149
    | YMM4 = 150
    | YMM5 = 151
    | YMM6 = 152
    | YMM7 = 153
    | YMM8 = 154
    | YMM9 = 155
    | YMM10 = 156
    | YMM11 = 157
    | YMM12 = 158
    | YMM13 = 159
    | YMM14 = 160
    | YMM15 = 161
    | YMM16 = 162
    | YMM17 = 163
    | YMM18 = 164
    | YMM19 = 165
    | YMM20 = 166
    | YMM21 = 167
    | YMM22 = 168
    | YMM23 = 169
    | YMM24 = 170
    | YMM25 = 171
    | YMM26 = 172
    | YMM27 = 173
    | YMM28 = 174
    | YMM29 = 175
    | YMM30 = 176
    | YMM31 = 177
    | ZMM0 = 178
    | ZMM1 = 179
    | ZMM2 = 180
    | ZMM3 = 181
    | ZMM4 = 182
    | ZMM5 = 183
    | ZMM6 = 184
    | ZMM7 = 185
    | ZMM8 = 186
    | ZMM9 = 187
    | ZMM10 = 188
    | ZMM11 = 189
    | ZMM12 = 190
    | ZMM13 = 191
    | ZMM14 = 192
    | ZMM15 = 193
    | ZMM16 = 194
    | ZMM17 = 195
    | ZMM18 = 196
    | ZMM19 = 197
    | ZMM20 = 198
    | ZMM21 = 199
    | ZMM22 = 200
    | ZMM23 = 201
    | ZMM24 = 202
    | ZMM25 = 203
    | ZMM26 = 204
    | ZMM27 = 205
    | ZMM28 = 206
    | ZMM29 = 207
    | ZMM30 = 208
    | ZMM31 = 209
    | R8B = 210
    | R9B = 211
    | R10B = 212
    | R11B = 213
    | R12B = 214
    | R13B = 215
    | R14B = 216
    | R15B = 217
    | R8D = 218
    | R9D = 219
    | R10D = 220
    | R11D = 221
    | R12D = 222
    | R13D = 223
    | R14D = 224
    | R15D = 225
    | R8W = 226
    | R9W = 227
    | R10W = 228
    | R11W = 229
    | R12W = 230
    | R13W = 231
    | R14W = 232
    | R15W = 233

type InstructionGroup = 
    | None = 0
    | JUMP = 1
    | CALL = 2
    | RET = 3
    | INT = 4
    | IRET = 5
    // Architecture-specific groups
    | VM = 128
    | ``3DNOW`` = 129
    | AES = 130
    | ADX = 131
    | AVX = 132
    | AVX2 = 133
    | AVX512 = 134
    | BMI = 135
    | BMI2 = 136
    | CMOV = 137
    | F16C = 138
    | FMA = 139
    | FMA4 = 140
    | FSGSBASE = 141
    | HLE = 142
    | MMX = 143
    | MODE32 = 144
    | MODE64 = 145
    | RTM = 146
    | SHA = 147
    | SSE1 = 148
    | SSE2 = 149
    | SSE3 = 150
    | SSE41 = 151
    | SSE42 = 152
    | SSE4A = 153
    | SSSE3 = 154
    | PCLMUL = 155
    | XOP = 156
    | CDI = 157
    | ERI = 158
    | TBM = 159
    | ``16BITMODE`` = 160
    | NOT64BITMODE = 161
    | SGX = 162
    | DQI = 163
    | BWI = 164
    | PFI = 165
    | VLX = 166
    | SMAP = 167
    | NOVLX = 168

type Opcode = 
    | Invalid = 0
    | AAA = 1
    | AAD = 2
    | AAM = 3
    | AAS = 4
    | FABS = 5
    | ADC = 6
    | ADCX = 7
    | ADD = 8
    | ADDPD = 9
    | ADDPS = 10
    | ADDSD = 11
    | ADDSS = 12
    | ADDSUBPD = 13
    | ADDSUBPS = 14
    | FADD = 15
    | FIADD = 16
    | FADDP = 17
    | ADOX = 18
    | AESDECLAST = 19
    | AESDEC = 20
    | AESENCLAST = 21
    | AESENC = 22
    | AESIMC = 23
    | AESKEYGENASSIST = 24
    | AND = 25
    | ANDN = 26
    | ANDNPD = 27
    | ANDNPS = 28
    | ANDPD = 29
    | ANDPS = 30
    | ARPL = 31
    | BEXTR = 32
    | BLCFILL = 33
    | BLCI = 34
    | BLCIC = 35
    | BLCMSK = 36
    | BLCS = 37
    | BLENDPD = 38
    | BLENDPS = 39
    | BLENDVPD = 40
    | BLENDVPS = 41
    | BLSFILL = 42
    | BLSI = 43
    | BLSIC = 44
    | BLSMSK = 45
    | BLSR = 46
    | BOUND = 47
    | BSF = 48
    | BSR = 49
    | BSWAP = 50
    | BT = 51
    | BTC = 52
    | BTR = 53
    | BTS = 54
    | BZHI = 55
    | CALL = 56
    | CBW = 57
    | CDQ = 58
    | CDQE = 59
    | FCHS = 60
    | CLAC = 61
    | CLC = 62
    | CLD = 63
    | CLFLUSH = 64
    | CLGI = 65
    | CLI = 66
    | CLTS = 67
    | CMC = 68
    | CMOVA = 69
    | CMOVAE = 70
    | CMOVB = 71
    | CMOVBE = 72
    | FCMOVBE = 73
    | FCMOVB = 74
    | CMOVE = 75
    | FCMOVE = 76
    | CMOVG = 77
    | CMOVGE = 78
    | CMOVL = 79
    | CMOVLE = 80
    | FCMOVNBE = 81
    | FCMOVNB = 82
    | CMOVNE = 83
    | FCMOVNE = 84
    | CMOVNO = 85
    | CMOVNP = 86
    | FCMOVNU = 87
    | CMOVNS = 88
    | CMOVO = 89
    | CMOVP = 90
    | FCMOVU = 91
    | CMOVS = 92
    | CMP = 93
    | CMPPD = 94
    | CMPPS = 95
    | CMPSB = 96
    | CMPSD = 97
    | CMPSQ = 98
    | CMPSS = 99
    | CMPSW = 100
    | CMPXCHG16B = 101
    | CMPXCHG = 102
    | CMPXCHG8B = 103
    | COMISD = 104
    | COMISS = 105
    | FCOMP = 106
    | FCOMPI = 107
    | FCOMI = 108
    | FCOM = 109
    | FCOS = 110
    | CPUID = 111
    | CQO = 112
    | CRC32 = 113
    | CVTDQ2PD = 114
    | CVTDQ2PS = 115
    | CVTPD2DQ = 116
    | CVTPD2PS = 117
    | CVTPS2DQ = 118
    | CVTPS2PD = 119
    | CVTSD2SI = 120
    | CVTSD2SS = 121
    | CVTSI2SD = 122
    | CVTSI2SS = 123
    | CVTSS2SD = 124
    | CVTSS2SI = 125
    | CVTTPD2DQ = 126
    | CVTTPS2DQ = 127
    | CVTTSD2SI = 128
    | CVTTSS2SI = 129
    | CWD = 130
    | CWDE = 131
    | DAA = 132
    | DAS = 133
    | DATA16 = 134
    | DEC = 135
    | DIV = 136
    | DIVPD = 137
    | DIVPS = 138
    | FDIVR = 139
    | FIDIVR = 140
    | FDIVRP = 141
    | DIVSD = 142
    | DIVSS = 143
    | FDIV = 144
    | FIDIV = 145
    | FDIVP = 146
    | DPPD = 147
    | DPPS = 148
    | RET = 149
    | ENCLS = 150
    | ENCLU = 151
    | ENTER = 152
    | EXTRACTPS = 153
    | EXTRQ = 154
    | F2XM1 = 155
    | LCALL = 156
    | LJMP = 157
    | FBLD = 158
    | FBSTP = 159
    | FCOMPP = 160
    | FDECSTP = 161
    | FEMMS = 162
    | FFREE = 163
    | FICOM = 164
    | FICOMP = 165
    | FINCSTP = 166
    | FLDCW = 167
    | FLDENV = 168
    | FLDL2E = 169
    | FLDL2T = 170
    | FLDLG2 = 171
    | FLDLN2 = 172
    | FLDPI = 173
    | FNCLEX = 174
    | FNINIT = 175
    | FNOP = 176
    | FNSTCW = 177
    | FNSTSW = 178
    | FPATAN = 179
    | FPREM = 180
    | FPREM1 = 181
    | FPTAN = 182
    | FRNDINT = 183
    | FRSTOR = 184
    | FNSAVE = 185
    | FSCALE = 186
    | FSETPM = 187
    | FSINCOS = 188
    | FNSTENV = 189
    | FXAM = 190
    | FXRSTOR = 191
    | FXRSTOR64 = 192
    | FXSAVE = 193
    | FXSAVE64 = 194
    | FXTRACT = 195
    | FYL2X = 196
    | FYL2XP1 = 197
    | MOVAPD = 198
    | MOVAPS = 199
    | ORPD = 200
    | ORPS = 201
    | VMOVAPD = 202
    | VMOVAPS = 203
    | XORPD = 204
    | XORPS = 205
    | GETSEC = 206
    | HADDPD = 207
    | HADDPS = 208
    | HLT = 209
    | HSUBPD = 210
    | HSUBPS = 211
    | IDIV = 212
    | FILD = 213
    | IMUL = 214
    | IN = 215
    | INC = 216
    | INSB = 217
    | INSERTPS = 218
    | INSERTQ = 219
    | INSD = 220
    | INSW = 221
    | INT = 222
    | INT1 = 223
    | INT3 = 224
    | INTO = 225
    | INVD = 226
    | INVEPT = 227
    | INVLPG = 228
    | INVLPGA = 229
    | INVPCID = 230
    | INVVPID = 231
    | IRET = 232
    | IRETD = 233
    | IRETQ = 234
    | FISTTP = 235
    | FIST = 236
    | FISTP = 237
    | UCOMISD = 238
    | UCOMISS = 239
    | VCMP = 240
    | VCOMISD = 241
    | VCOMISS = 242
    | VCVTSD2SS = 243
    | VCVTSI2SD = 244
    | VCVTSI2SS = 245
    | VCVTSS2SD = 246
    | VCVTTSD2SI = 247
    | VCVTTSD2USI = 248
    | VCVTTSS2SI = 249
    | VCVTTSS2USI = 250
    | VCVTUSI2SD = 251
    | VCVTUSI2SS = 252
    | VUCOMISD = 253
    | VUCOMISS = 254
    | JAE = 255
    | JA = 256
    | JBE = 257
    | JB = 258
    | JCXZ = 259
    | JECXZ = 260
    | JE = 261
    | JGE = 262
    | JG = 263
    | JLE = 264
    | JL = 265
    | JMP = 266
    | JNE = 267
    | JNO = 268
    | JNP = 269
    | JNS = 270
    | JO = 271
    | JP = 272
    | JRCXZ = 273
    | JS = 274
    | KANDB = 275
    | KANDD = 276
    | KANDNB = 277
    | KANDND = 278
    | KANDNQ = 279
    | KANDNW = 280
    | KANDQ = 281
    | KANDW = 282
    | KMOVB = 283
    | KMOVD = 284
    | KMOVQ = 285
    | KMOVW = 286
    | KNOTB = 287
    | KNOTD = 288
    | KNOTQ = 289
    | KNOTW = 290
    | KORB = 291
    | KORD = 292
    | KORQ = 293
    | KORTESTW = 294
    | KORW = 295
    | KSHIFTLW = 296
    | KSHIFTRW = 297
    | KUNPCKBW = 298
    | KXNORB = 299
    | KXNORD = 300
    | KXNORQ = 301
    | KXNORW = 302
    | KXORB = 303
    | KXORD = 304
    | KXORQ = 305
    | KXORW = 306
    | LAHF = 307
    | LAR = 308
    | LDDQU = 309
    | LDMXCSR = 310
    | LDS = 311
    | FLDZ = 312
    | FLD1 = 313
    | FLD = 314
    | LEA = 315
    | LEAVE = 316
    | LES = 317
    | LFENCE = 318
    | LFS = 319
    | LGDT = 320
    | LGS = 321
    | LIDT = 322
    | LLDT = 323
    | LMSW = 324
    | OR = 325
    | SUB = 326
    | XOR = 327
    | LODSB = 328
    | LODSD = 329
    | LODSQ = 330
    | LODSW = 331
    | LOOP = 332
    | LOOPE = 333
    | LOOPNE = 334
    | RETF = 335
    | RETFQ = 336
    | LSL = 337
    | LSS = 338
    | LTR = 339
    | XADD = 340
    | LZCNT = 341
    | MASKMOVDQU = 342
    | MAXPD = 343
    | MAXPS = 344
    | MAXSD = 345
    | MAXSS = 346
    | MFENCE = 347
    | MINPD = 348
    | MINPS = 349
    | MINSD = 350
    | MINSS = 351
    | CVTPD2PI = 352
    | CVTPI2PD = 353
    | CVTPI2PS = 354
    | CVTPS2PI = 355
    | CVTTPD2PI = 356
    | CVTTPS2PI = 357
    | EMMS = 358
    | MASKMOVQ = 359
    | MOVD = 360
    | MOVDQ2Q = 361
    | MOVNTQ = 362
    | MOVQ2DQ = 363
    | MOVQ = 364
    | PABSB = 365
    | PABSD = 366
    | PABSW = 367
    | PACKSSDW = 368
    | PACKSSWB = 369
    | PACKUSWB = 370
    | PADDB = 371
    | PADDD = 372
    | PADDQ = 373
    | PADDSB = 374
    | PADDSW = 375
    | PADDUSB = 376
    | PADDUSW = 377
    | PADDW = 378
    | PALIGNR = 379
    | PANDN = 380
    | PAND = 381
    | PAVGB = 382
    | PAVGW = 383
    | PCMPEQB = 384
    | PCMPEQD = 385
    | PCMPEQW = 386
    | PCMPGTB = 387
    | PCMPGTD = 388
    | PCMPGTW = 389
    | PEXTRW = 390
    | PHADDSW = 391
    | PHADDW = 392
    | PHADDD = 393
    | PHSUBD = 394
    | PHSUBSW = 395
    | PHSUBW = 396
    | PINSRW = 397
    | PMADDUBSW = 398
    | PMADDWD = 399
    | PMAXSW = 400
    | PMAXUB = 401
    | PMINSW = 402
    | PMINUB = 403
    | PMOVMSKB = 404
    | PMULHRSW = 405
    | PMULHUW = 406
    | PMULHW = 407
    | PMULLW = 408
    | PMULUDQ = 409
    | POR = 410
    | PSADBW = 411
    | PSHUFB = 412
    | PSHUFW = 413
    | PSIGNB = 414
    | PSIGND = 415
    | PSIGNW = 416
    | PSLLD = 417
    | PSLLQ = 418
    | PSLLW = 419
    | PSRAD = 420
    | PSRAW = 421
    | PSRLD = 422
    | PSRLQ = 423
    | PSRLW = 424
    | PSUBB = 425
    | PSUBD = 426
    | PSUBQ = 427
    | PSUBSB = 428
    | PSUBSW = 429
    | PSUBUSB = 430
    | PSUBUSW = 431
    | PSUBW = 432
    | PUNPCKHBW = 433
    | PUNPCKHDQ = 434
    | PUNPCKHWD = 435
    | PUNPCKLBW = 436
    | PUNPCKLDQ = 437
    | PUNPCKLWD = 438
    | PXOR = 439
    | MONITOR = 440
    | MONTMUL = 441
    | MOV = 442
    | MOVABS = 443
    | MOVBE = 444
    | MOVDDUP = 445
    | MOVDQA = 446
    | MOVDQU = 447
    | MOVHLPS = 448
    | MOVHPD = 449
    | MOVHPS = 450
    | MOVLHPS = 451
    | MOVLPD = 452
    | MOVLPS = 453
    | MOVMSKPD = 454
    | MOVMSKPS = 455
    | MOVNTDQA = 456
    | MOVNTDQ = 457
    | MOVNTI = 458
    | MOVNTPD = 459
    | MOVNTPS = 460
    | MOVNTSD = 461
    | MOVNTSS = 462
    | MOVSB = 463
    | MOVSD = 464
    | MOVSHDUP = 465
    | MOVSLDUP = 466
    | MOVSQ = 467
    | MOVSS = 468
    | MOVSW = 469
    | MOVSX = 470
    | MOVSXD = 471
    | MOVUPD = 472
    | MOVUPS = 473
    | MOVZX = 474
    | MPSADBW = 475
    | MUL = 476
    | MULPD = 477
    | MULPS = 478
    | MULSD = 479
    | MULSS = 480
    | MULX = 481
    | FMUL = 482
    | FIMUL = 483
    | FMULP = 484
    | MWAIT = 485
    | NEG = 486
    | NOP = 487
    | NOT = 488
    | OUT = 489
    | OUTSB = 490
    | OUTSD = 491
    | OUTSW = 492
    | PACKUSDW = 493
    | PAUSE = 494
    | PAVGUSB = 495
    | PBLENDVB = 496
    | PBLENDW = 497
    | PCLMULQDQ = 498
    | PCMPEQQ = 499
    | PCMPESTRI = 500
    | PCMPESTRM = 501
    | PCMPGTQ = 502
    | PCMPISTRI = 503
    | PCMPISTRM = 504
    | PDEP = 505
    | PEXT = 506
    | PEXTRB = 507
    | PEXTRD = 508
    | PEXTRQ = 509
    | PF2ID = 510
    | PF2IW = 511
    | PFACC = 512
    | PFADD = 513
    | PFCMPEQ = 514
    | PFCMPGE = 515
    | PFCMPGT = 516
    | PFMAX = 517
    | PFMIN = 518
    | PFMUL = 519
    | PFNACC = 520
    | PFPNACC = 521
    | PFRCPIT1 = 522
    | PFRCPIT2 = 523
    | PFRCP = 524
    | PFRSQIT1 = 525
    | PFRSQRT = 526
    | PFSUBR = 527
    | PFSUB = 528
    | PHMINPOSUW = 529
    | PI2FD = 530
    | PI2FW = 531
    | PINSRB = 532
    | PINSRD = 533
    | PINSRQ = 534
    | PMAXSB = 535
    | PMAXSD = 536
    | PMAXUD = 537
    | PMAXUW = 538
    | PMINSB = 539
    | PMINSD = 540
    | PMINUD = 541
    | PMINUW = 542
    | PMOVSXBD = 543
    | PMOVSXBQ = 544
    | PMOVSXBW = 545
    | PMOVSXDQ = 546
    | PMOVSXWD = 547
    | PMOVSXWQ = 548
    | PMOVZXBD = 549
    | PMOVZXBQ = 550
    | PMOVZXBW = 551
    | PMOVZXDQ = 552
    | PMOVZXWD = 553
    | PMOVZXWQ = 554
    | PMULDQ = 555
    | PMULHRW = 556
    | PMULLD = 557
    | POP = 558
    | POPAW = 559
    | POPAL = 560
    | POPCNT = 561
    | POPF = 562
    | POPFD = 563
    | POPFQ = 564
    | PREFETCH = 565
    | PREFETCHNTA = 566
    | PREFETCHT0 = 567
    | PREFETCHT1 = 568
    | PREFETCHT2 = 569
    | PREFETCHW = 570
    | PSHUFD = 571
    | PSHUFHW = 572
    | PSHUFLW = 573
    | PSLLDQ = 574
    | PSRLDQ = 575
    | PSWAPD = 576
    | PTEST = 577
    | PUNPCKHQDQ = 578
    | PUNPCKLQDQ = 579
    | PUSH = 580
    | PUSHAW = 581
    | PUSHAL = 582
    | PUSHF = 583
    | PUSHFD = 584
    | PUSHFQ = 585
    | RCL = 586
    | RCPPS = 587
    | RCPSS = 588
    | RCR = 589
    | RDFSBASE = 590
    | RDGSBASE = 591
    | RDMSR = 592
    | RDPMC = 593
    | RDRAND = 594
    | RDSEED = 595
    | RDTSC = 596
    | RDTSCP = 597
    | ROL = 598
    | ROR = 599
    | RORX = 600
    | ROUNDPD = 601
    | ROUNDPS = 602
    | ROUNDSD = 603
    | ROUNDSS = 604
    | RSM = 605
    | RSQRTPS = 606
    | RSQRTSS = 607
    | SAHF = 608
    | SAL = 609
    | SALC = 610
    | SAR = 611
    | SARX = 612
    | SBB = 613
    | SCASB = 614
    | SCASD = 615
    | SCASQ = 616
    | SCASW = 617
    | SETAE = 618
    | SETA = 619
    | SETBE = 620
    | SETB = 621
    | SETE = 622
    | SETGE = 623
    | SETG = 624
    | SETLE = 625
    | SETL = 626
    | SETNE = 627
    | SETNO = 628
    | SETNP = 629
    | SETNS = 630
    | SETO = 631
    | SETP = 632
    | SETS = 633
    | SFENCE = 634
    | SGDT = 635
    | SHA1MSG1 = 636
    | SHA1MSG2 = 637
    | SHA1NEXTE = 638
    | SHA1RNDS4 = 639
    | SHA256MSG1 = 640
    | SHA256MSG2 = 641
    | SHA256RNDS2 = 642
    | SHL = 643
    | SHLD = 644
    | SHLX = 645
    | SHR = 646
    | SHRD = 647
    | SHRX = 648
    | SHUFPD = 649
    | SHUFPS = 650
    | SIDT = 651
    | FSIN = 652
    | SKINIT = 653
    | SLDT = 654
    | SMSW = 655
    | SQRTPD = 656
    | SQRTPS = 657
    | SQRTSD = 658
    | SQRTSS = 659
    | FSQRT = 660
    | STAC = 661
    | STC = 662
    | STD = 663
    | STGI = 664
    | STI = 665
    | STMXCSR = 666
    | STOSB = 667
    | STOSD = 668
    | STOSQ = 669
    | STOSW = 670
    | STR = 671
    | FST = 672
    | FSTP = 673
    | FSTPNCE = 674
    | SUBPD = 675
    | SUBPS = 676
    | FSUBR = 677
    | FISUBR = 678
    | FSUBRP = 679
    | SUBSD = 680
    | SUBSS = 681
    | FSUB = 682
    | FISUB = 683
    | FSUBP = 684
    | SWAPGS = 685
    | SYSCALL = 686
    | SYSENTER = 687
    | SYSEXIT = 688
    | SYSRET = 689
    | T1MSKC = 690
    | TEST = 691
    | UD2 = 692
    | FTST = 693
    | TZCNT = 694
    | TZMSK = 695
    | FUCOMPI = 696
    | FUCOMI = 697
    | FUCOMPP = 698
    | FUCOMP = 699
    | FUCOM = 700
    | UD2B = 701
    | UNPCKHPD = 702
    | UNPCKHPS = 703
    | UNPCKLPD = 704
    | UNPCKLPS = 705
    | VADDPD = 706
    | VADDPS = 707
    | VADDSD = 708
    | VADDSS = 709
    | VADDSUBPD = 710
    | VADDSUBPS = 711
    | VAESDECLAST = 712
    | VAESDEC = 713
    | VAESENCLAST = 714
    | VAESENC = 715
    | VAESIMC = 716
    | VAESKEYGENASSIST = 717
    | VALIGND = 718
    | VALIGNQ = 719
    | VANDNPD = 720
    | VANDNPS = 721
    | VANDPD = 722
    | VANDPS = 723
    | VBLENDMPD = 724
    | VBLENDMPS = 725
    | VBLENDPD = 726
    | VBLENDPS = 727
    | VBLENDVPD = 728
    | VBLENDVPS = 729
    | VBROADCASTF128 = 730
    | VBROADCASTI128 = 731
    | VBROADCASTI32X4 = 732
    | VBROADCASTI64X4 = 733
    | VBROADCASTSD = 734
    | VBROADCASTSS = 735
    | VCMPPD = 736
    | VCMPPS = 737
    | VCMPSD = 738
    | VCMPSS = 739
    | VCVTDQ2PD = 740
    | VCVTDQ2PS = 741
    | VCVTPD2DQX = 742
    | VCVTPD2DQ = 743
    | VCVTPD2PSX = 744
    | VCVTPD2PS = 745
    | VCVTPD2UDQ = 746
    | VCVTPH2PS = 747
    | VCVTPS2DQ = 748
    | VCVTPS2PD = 749
    | VCVTPS2PH = 750
    | VCVTPS2UDQ = 751
    | VCVTSD2SI = 752
    | VCVTSD2USI = 753
    | VCVTSS2SI = 754
    | VCVTSS2USI = 755
    | VCVTTPD2DQX = 756
    | VCVTTPD2DQ = 757
    | VCVTTPD2UDQ = 758
    | VCVTTPS2DQ = 759
    | VCVTTPS2UDQ = 760
    | VCVTUDQ2PD = 761
    | VCVTUDQ2PS = 762
    | VDIVPD = 763
    | VDIVPS = 764
    | VDIVSD = 765
    | VDIVSS = 766
    | VDPPD = 767
    | VDPPS = 768
    | VERR = 769
    | VERW = 770
    | VEXTRACTF128 = 771
    | VEXTRACTF32X4 = 772
    | VEXTRACTF64X4 = 773
    | VEXTRACTI128 = 774
    | VEXTRACTI32X4 = 775
    | VEXTRACTI64X4 = 776
    | VEXTRACTPS = 777
    | VFMADD132PD = 778
    | VFMADD132PS = 779
    | VFMADD213PD = 780
    | VFMADD213PS = 781
    | VFMADDPD = 782
    | VFMADD231PD = 783
    | VFMADDPS = 784
    | VFMADD231PS = 785
    | VFMADDSD = 786
    | VFMADD213SD = 787
    | VFMADD132SD = 788
    | VFMADD231SD = 789
    | VFMADDSS = 790
    | VFMADD213SS = 791
    | VFMADD132SS = 792
    | VFMADD231SS = 793
    | VFMADDSUB132PD = 794
    | VFMADDSUB132PS = 795
    | VFMADDSUB213PD = 796
    | VFMADDSUB213PS = 797
    | VFMADDSUBPD = 798
    | VFMADDSUB231PD = 799
    | VFMADDSUBPS = 800
    | VFMADDSUB231PS = 801
    | VFMSUB132PD = 802
    | VFMSUB132PS = 803
    | VFMSUB213PD = 804
    | VFMSUB213PS = 805
    | VFMSUBADD132PD = 806
    | VFMSUBADD132PS = 807
    | VFMSUBADD213PD = 808
    | VFMSUBADD213PS = 809
    | VFMSUBADDPD = 810
    | VFMSUBADD231PD = 811
    | VFMSUBADDPS = 812
    | VFMSUBADD231PS = 813
    | VFMSUBPD = 814
    | VFMSUB231PD = 815
    | VFMSUBPS = 816
    | VFMSUB231PS = 817
    | VFMSUBSD = 818
    | VFMSUB213SD = 819
    | VFMSUB132SD = 820
    | VFMSUB231SD = 821
    | VFMSUBSS = 822
    | VFMSUB213SS = 823
    | VFMSUB132SS = 824
    | VFMSUB231SS = 825
    | VFNMADD132PD = 826
    | VFNMADD132PS = 827
    | VFNMADD213PD = 828
    | VFNMADD213PS = 829
    | VFNMADDPD = 830
    | VFNMADD231PD = 831
    | VFNMADDPS = 832
    | VFNMADD231PS = 833
    | VFNMADDSD = 834
    | VFNMADD213SD = 835
    | VFNMADD132SD = 836
    | VFNMADD231SD = 837
    | VFNMADDSS = 838
    | VFNMADD213SS = 839
    | VFNMADD132SS = 840
    | VFNMADD231SS = 841
    | VFNMSUB132PD = 842
    | VFNMSUB132PS = 843
    | VFNMSUB213PD = 844
    | VFNMSUB213PS = 845
    | VFNMSUBPD = 846
    | VFNMSUB231PD = 847
    | VFNMSUBPS = 848
    | VFNMSUB231PS = 849
    | VFNMSUBSD = 850
    | VFNMSUB213SD = 851
    | VFNMSUB132SD = 852
    | VFNMSUB231SD = 853
    | VFNMSUBSS = 854
    | VFNMSUB213SS = 855
    | VFNMSUB132SS = 856
    | VFNMSUB231SS = 857
    | VFRCZPD = 858
    | VFRCZPS = 859
    | VFRCZSD = 860
    | VFRCZSS = 861
    | VORPD = 862
    | VORPS = 863
    | VXORPD = 864
    | VXORPS = 865
    | VGATHERDPD = 866
    | VGATHERDPS = 867
    | VGATHERPF0DPD = 868
    | VGATHERPF0DPS = 869
    | VGATHERPF0QPD = 870
    | VGATHERPF0QPS = 871
    | VGATHERPF1DPD = 872
    | VGATHERPF1DPS = 873
    | VGATHERPF1QPD = 874
    | VGATHERPF1QPS = 875
    | VGATHERQPD = 876
    | VGATHERQPS = 877
    | VHADDPD = 878
    | VHADDPS = 879
    | VHSUBPD = 880
    | VHSUBPS = 881
    | VINSERTF128 = 882
    | VINSERTF32X4 = 883
    | VINSERTF64X4 = 884
    | VINSERTI128 = 885
    | VINSERTI32X4 = 886
    | VINSERTI64X4 = 887
    | VINSERTPS = 888
    | VLDDQU = 889
    | VLDMXCSR = 890
    | VMASKMOVDQU = 891
    | VMASKMOVPD = 892
    | VMASKMOVPS = 893
    | VMAXPD = 894
    | VMAXPS = 895
    | VMAXSD = 896
    | VMAXSS = 897
    | VMCALL = 898
    | VMCLEAR = 899
    | VMFUNC = 900
    | VMINPD = 901
    | VMINPS = 902
    | VMINSD = 903
    | VMINSS = 904
    | VMLAUNCH = 905
    | VMLOAD = 906
    | VMMCALL = 907
    | VMOVQ = 908
    | VMOVDDUP = 909
    | VMOVD = 910
    | VMOVDQA32 = 911
    | VMOVDQA64 = 912
    | VMOVDQA = 913
    | VMOVDQU16 = 914
    | VMOVDQU32 = 915
    | VMOVDQU64 = 916
    | VMOVDQU8 = 917
    | VMOVDQU = 918
    | VMOVHLPS = 919
    | VMOVHPD = 920
    | VMOVHPS = 921
    | VMOVLHPS = 922
    | VMOVLPD = 923
    | VMOVLPS = 924
    | VMOVMSKPD = 925
    | VMOVMSKPS = 926
    | VMOVNTDQA = 927
    | VMOVNTDQ = 928
    | VMOVNTPD = 929
    | VMOVNTPS = 930
    | VMOVSD = 931
    | VMOVSHDUP = 932
    | VMOVSLDUP = 933
    | VMOVSS = 934
    | VMOVUPD = 935
    | VMOVUPS = 936
    | VMPSADBW = 937
    | VMPTRLD = 938
    | VMPTRST = 939
    | VMREAD = 940
    | VMRESUME = 941
    | VMRUN = 942
    | VMSAVE = 943
    | VMULPD = 944
    | VMULPS = 945
    | VMULSD = 946
    | VMULSS = 947
    | VMWRITE = 948
    | VMXOFF = 949
    | VMXON = 950
    | VPABSB = 951
    | VPABSD = 952
    | VPABSQ = 953
    | VPABSW = 954
    | VPACKSSDW = 955
    | VPACKSSWB = 956
    | VPACKUSDW = 957
    | VPACKUSWB = 958
    | VPADDB = 959
    | VPADDD = 960
    | VPADDQ = 961
    | VPADDSB = 962
    | VPADDSW = 963
    | VPADDUSB = 964
    | VPADDUSW = 965
    | VPADDW = 966
    | VPALIGNR = 967
    | VPANDD = 968
    | VPANDND = 969
    | VPANDNQ = 970
    | VPANDN = 971
    | VPANDQ = 972
    | VPAND = 973
    | VPAVGB = 974
    | VPAVGW = 975
    | VPBLENDD = 976
    | VPBLENDMD = 977
    | VPBLENDMQ = 978
    | VPBLENDVB = 979
    | VPBLENDW = 980
    | VPBROADCASTB = 981
    | VPBROADCASTD = 982
    | VPBROADCASTMB2Q = 983
    | VPBROADCASTMW2D = 984
    | VPBROADCASTQ = 985
    | VPBROADCASTW = 986
    | VPCLMULQDQ = 987
    | VPCMOV = 988
    | VPCMP = 989
    | VPCMPD = 990
    | VPCMPEQB = 991
    | VPCMPEQD = 992
    | VPCMPEQQ = 993
    | VPCMPEQW = 994
    | VPCMPESTRI = 995
    | VPCMPESTRM = 996
    | VPCMPGTB = 997
    | VPCMPGTD = 998
    | VPCMPGTQ = 999
    | VPCMPGTW = 1000
    | VPCMPISTRI = 1001
    | VPCMPISTRM = 1002
    | VPCMPQ = 1003
    | VPCMPUD = 1004
    | VPCMPUQ = 1005
    | VPCOMB = 1006
    | VPCOMD = 1007
    | VPCOMQ = 1008
    | VPCOMUB = 1009
    | VPCOMUD = 1010
    | VPCOMUQ = 1011
    | VPCOMUW = 1012
    | VPCOMW = 1013
    | VPCONFLICTD = 1014
    | VPCONFLICTQ = 1015
    | VPERM2F128 = 1016
    | VPERM2I128 = 1017
    | VPERMD = 1018
    | VPERMI2D = 1019
    | VPERMI2PD = 1020
    | VPERMI2PS = 1021
    | VPERMI2Q = 1022
    | VPERMIL2PD = 1023
    | VPERMIL2PS = 1024
    | VPERMILPD = 1025
    | VPERMILPS = 1026
    | VPERMPD = 1027
    | VPERMPS = 1028
    | VPERMQ = 1029
    | VPERMT2D = 1030
    | VPERMT2PD = 1031
    | VPERMT2PS = 1032
    | VPERMT2Q = 1033
    | VPEXTRB = 1034
    | VPEXTRD = 1035
    | VPEXTRQ = 1036
    | VPEXTRW = 1037
    | VPGATHERDD = 1038
    | VPGATHERDQ = 1039
    | VPGATHERQD = 1040
    | VPGATHERQQ = 1041
    | VPHADDBD = 1042
    | VPHADDBQ = 1043
    | VPHADDBW = 1044
    | VPHADDDQ = 1045
    | VPHADDD = 1046
    | VPHADDSW = 1047
    | VPHADDUBD = 1048
    | VPHADDUBQ = 1049
    | VPHADDUBW = 1050
    | VPHADDUDQ = 1051
    | VPHADDUWD = 1052
    | VPHADDUWQ = 1053
    | VPHADDWD = 1054
    | VPHADDWQ = 1055
    | VPHADDW = 1056
    | VPHMINPOSUW = 1057
    | VPHSUBBW = 1058
    | VPHSUBDQ = 1059
    | VPHSUBD = 1060
    | VPHSUBSW = 1061
    | VPHSUBWD = 1062
    | VPHSUBW = 1063
    | VPINSRB = 1064
    | VPINSRD = 1065
    | VPINSRQ = 1066
    | VPINSRW = 1067
    | VPLZCNTD = 1068
    | VPLZCNTQ = 1069
    | VPMACSDD = 1070
    | VPMACSDQH = 1071
    | VPMACSDQL = 1072
    | VPMACSSDD = 1073
    | VPMACSSDQH = 1074
    | VPMACSSDQL = 1075
    | VPMACSSWD = 1076
    | VPMACSSWW = 1077
    | VPMACSWD = 1078
    | VPMACSWW = 1079
    | VPMADCSSWD = 1080
    | VPMADCSWD = 1081
    | VPMADDUBSW = 1082
    | VPMADDWD = 1083
    | VPMASKMOVD = 1084
    | VPMASKMOVQ = 1085
    | VPMAXSB = 1086
    | VPMAXSD = 1087
    | VPMAXSQ = 1088
    | VPMAXSW = 1089
    | VPMAXUB = 1090
    | VPMAXUD = 1091
    | VPMAXUQ = 1092
    | VPMAXUW = 1093
    | VPMINSB = 1094
    | VPMINSD = 1095
    | VPMINSQ = 1096
    | VPMINSW = 1097
    | VPMINUB = 1098
    | VPMINUD = 1099
    | VPMINUQ = 1100
    | VPMINUW = 1101
    | VPMOVDB = 1102
    | VPMOVDW = 1103
    | VPMOVMSKB = 1104
    | VPMOVQB = 1105
    | VPMOVQD = 1106
    | VPMOVQW = 1107
    | VPMOVSDB = 1108
    | VPMOVSDW = 1109
    | VPMOVSQB = 1110
    | VPMOVSQD = 1111
    | VPMOVSQW = 1112
    | VPMOVSXBD = 1113
    | VPMOVSXBQ = 1114
    | VPMOVSXBW = 1115
    | VPMOVSXDQ = 1116
    | VPMOVSXWD = 1117
    | VPMOVSXWQ = 1118
    | VPMOVUSDB = 1119
    | VPMOVUSDW = 1120
    | VPMOVUSQB = 1121
    | VPMOVUSQD = 1122
    | VPMOVUSQW = 1123
    | VPMOVZXBD = 1124
    | VPMOVZXBQ = 1125
    | VPMOVZXBW = 1126
    | VPMOVZXDQ = 1127
    | VPMOVZXWD = 1128
    | VPMOVZXWQ = 1129
    | VPMULDQ = 1130
    | VPMULHRSW = 1131
    | VPMULHUW = 1132
    | VPMULHW = 1133
    | VPMULLD = 1134
    | VPMULLW = 1135
    | VPMULUDQ = 1136
    | VPORD = 1137
    | VPORQ = 1138
    | VPOR = 1139
    | VPPERM = 1140
    | VPROTB = 1141
    | VPROTD = 1142
    | VPROTQ = 1143
    | VPROTW = 1144
    | VPSADBW = 1145
    | VPSCATTERDD = 1146
    | VPSCATTERDQ = 1147
    | VPSCATTERQD = 1148
    | VPSCATTERQQ = 1149
    | VPSHAB = 1150
    | VPSHAD = 1151
    | VPSHAQ = 1152
    | VPSHAW = 1153
    | VPSHLB = 1154
    | VPSHLD = 1155
    | VPSHLQ = 1156
    | VPSHLW = 1157
    | VPSHUFB = 1158
    | VPSHUFD = 1159
    | VPSHUFHW = 1160
    | VPSHUFLW = 1161
    | VPSIGNB = 1162
    | VPSIGND = 1163
    | VPSIGNW = 1164
    | VPSLLDQ = 1165
    | VPSLLD = 1166
    | VPSLLQ = 1167
    | VPSLLVD = 1168
    | VPSLLVQ = 1169
    | VPSLLW = 1170
    | VPSRAD = 1171
    | VPSRAQ = 1172
    | VPSRAVD = 1173
    | VPSRAVQ = 1174
    | VPSRAW = 1175
    | VPSRLDQ = 1176
    | VPSRLD = 1177
    | VPSRLQ = 1178
    | VPSRLVD = 1179
    | VPSRLVQ = 1180
    | VPSRLW = 1181
    | VPSUBB = 1182
    | VPSUBD = 1183
    | VPSUBQ = 1184
    | VPSUBSB = 1185
    | VPSUBSW = 1186
    | VPSUBUSB = 1187
    | VPSUBUSW = 1188
    | VPSUBW = 1189
    | VPTESTMD = 1190
    | VPTESTMQ = 1191
    | VPTESTNMD = 1192
    | VPTESTNMQ = 1193
    | VPTEST = 1194
    | VPUNPCKHBW = 1195
    | VPUNPCKHDQ = 1196
    | VPUNPCKHQDQ = 1197
    | VPUNPCKHWD = 1198
    | VPUNPCKLBW = 1199
    | VPUNPCKLDQ = 1200
    | VPUNPCKLQDQ = 1201
    | VPUNPCKLWD = 1202
    | VPXORD = 1203
    | VPXORQ = 1204
    | VPXOR = 1205
    | VRCP14PD = 1206
    | VRCP14PS = 1207
    | VRCP14SD = 1208
    | VRCP14SS = 1209
    | VRCP28PD = 1210
    | VRCP28PS = 1211
    | VRCP28SD = 1212
    | VRCP28SS = 1213
    | VRCPPS = 1214
    | VRCPSS = 1215
    | VRNDSCALEPD = 1216
    | VRNDSCALEPS = 1217
    | VRNDSCALESD = 1218
    | VRNDSCALESS = 1219
    | VROUNDPD = 1220
    | VROUNDPS = 1221
    | VROUNDSD = 1222
    | VROUNDSS = 1223
    | VRSQRT14PD = 1224
    | VRSQRT14PS = 1225
    | VRSQRT14SD = 1226
    | VRSQRT14SS = 1227
    | VRSQRT28PD = 1228
    | VRSQRT28PS = 1229
    | VRSQRT28SD = 1230
    | VRSQRT28SS = 1231
    | VRSQRTPS = 1232
    | VRSQRTSS = 1233
    | VSCATTERDPD = 1234
    | VSCATTERDPS = 1235
    | VSCATTERPF0DPD = 1236
    | VSCATTERPF0DPS = 1237
    | VSCATTERPF0QPD = 1238
    | VSCATTERPF0QPS = 1239
    | VSCATTERPF1DPD = 1240
    | VSCATTERPF1DPS = 1241
    | VSCATTERPF1QPD = 1242
    | VSCATTERPF1QPS = 1243
    | VSCATTERQPD = 1244
    | VSCATTERQPS = 1245
    | VSHUFPD = 1246
    | VSHUFPS = 1247
    | VSQRTPD = 1248
    | VSQRTPS = 1249
    | VSQRTSD = 1250
    | VSQRTSS = 1251
    | VSTMXCSR = 1252
    | VSUBPD = 1253
    | VSUBPS = 1254
    | VSUBSD = 1255
    | VSUBSS = 1256
    | VTESTPD = 1257
    | VTESTPS = 1258
    | VUNPCKHPD = 1259
    | VUNPCKHPS = 1260
    | VUNPCKLPD = 1261
    | VUNPCKLPS = 1262
    | VZEROALL = 1263
    | VZEROUPPER = 1264
    | WAIT = 1265
    | WBINVD = 1266
    | WRFSBASE = 1267
    | WRGSBASE = 1268
    | WRMSR = 1269
    | XABORT = 1270
    | XACQUIRE = 1271
    | XBEGIN = 1272
    | XCHG = 1273
    | FXCH = 1274
    | XCRYPTCBC = 1275
    | XCRYPTCFB = 1276
    | XCRYPTCTR = 1277
    | XCRYPTECB = 1278
    | XCRYPTOFB = 1279
    | XEND = 1280
    | XGETBV = 1281
    | XLATB = 1282
    | XRELEASE = 1283
    | XRSTOR = 1284
    | XRSTOR64 = 1285
    | XSAVE = 1286
    | XSAVE64 = 1287
    | XSAVEOPT = 1288
    | XSAVEOPT64 = 1289
    | XSETBV = 1290
    | XSHA1 = 1291
    | XSHA256 = 1292
    | XSTORE = 1293
    | XTEST = 1294
