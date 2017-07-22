namespace Capstone.FSharp.ARM

type ShiftKind =
    | None = 0
    | ASR = 1
    | LSL = 2
    | LSR = 3
    | ROR = 4
    | RRX = 5
    | ASR_REG = 6
    | LSL_REG = 7
    | LSR_REG = 8
    | ROR_REG = 9
    | RRX_REG = 10

type ConditionCode =
    | None = 0
    | EQ = 1
    | NE = 2
    | HS = 3
    | LO = 4
    | MI = 5
    | PL = 6
    | VS = 7
    | VC = 8
    | HI = 9
    | LS = 10
    | GE = 11
    | LT = 12
    | GT = 13
    | LE = 14
    | AL = 15

type Register =
    | None = 0
    | APSR = 1
    | APSR_NZCV = 2
    | CPSR = 3
    | FPEXC = 4
    | FPINST = 5
    | FPSCR = 6
    | FPSCR_NZCV = 7
    | FPSID = 8
    | ITSTATE = 9
    | LR = 10
    | PC = 11
    | SP = 12
    | SPSR = 13
    | D0 = 14
    | D1 = 15
    | D2 = 16
    | D3 = 17
    | D4 = 18
    | D5 = 19
    | D6 = 20
    | D7 = 21
    | D8 = 22
    | D9 = 23
    | D10 = 24
    | D11 = 25
    | D12 = 26
    | D13 = 27
    | D14 = 28
    | D15 = 29
    | D16 = 30
    | D17 = 31
    | D18 = 32
    | D19 = 33
    | D20 = 34
    | D21 = 35
    | D22 = 36
    | D23 = 37
    | D24 = 38
    | D25 = 39
    | D26 = 40
    | D27 = 41
    | D28 = 42
    | D29 = 43
    | D30 = 44
    | D31 = 45
    | FPINST2 = 46
    | MVFR0 = 47
    | MVFR1 = 48
    | Q0 = 49
    | Q1 = 50
    | Q2 = 51
    | Q3 = 52
    | Q4 = 53
    | Q5 = 54
    | Q6 = 55
    | Q7 = 56
    | Q8 = 57
    | Q9 = 58
    | Q10 = 59
    | Q11 = 60
    | Q12 = 61
    | Q13 = 62
    | Q14 = 63
    | Q15 = 64
    | R0 = 65
    | R1 = 66
    | R2 = 67
    | R3 = 68
    | R4 = 69
    | R5 = 70
    | R6 = 71
    | R7 = 72
    | R8 = 73
    | R9 = 74
    | R10 = 75
    | R11 = 76
    | R12 = 77
    | S0 = 78
    | S1 = 79
    | S2 = 80
    | S3 = 81
    | S4 = 82
    | S5 = 83
    | S6 = 84
    | S7 = 85
    | S8 = 86
    | S9 = 87
    | S10 = 88
    | S11 = 89
    | S12 = 90
    | S13 = 91
    | S14 = 92
    | S15 = 93
    | S16 = 94
    | S17 = 95
    | S18 = 96
    | S19 = 97
    | S20 = 98
    | S21 = 99
    | S22 = 100
    | S23 = 101
    | S24 = 102
    | S25 = 103
    | S26 = 104
    | S27 = 105
    | S28 = 106
    | S29 = 107
    | S30 = 108
    | S31 = 109

type Opcode =
    | None = 0
    | ADC = 1
    | ADD = 2
    | ADR = 3
    | AESD_8 = 4
    | AESE_8 = 5
    | AESIMC_8 = 6
    | AESMC_8 = 7
    | AND = 8
    | BFC = 9
    | BFI = 10
    | BIC = 11
    | BKPT = 12
    | BL = 13
    | BLX = 14
    | BX = 15
    | BXJ = 16
    | B = 17
    | CDP = 18
    | CDP2 = 19
    | CLREX = 20
    | CLZ = 21
    | CMN = 22
    | CMP = 23
    | CPS = 24
    | CRC32B = 25
    | CRC32CB = 26
    | CRC32CH = 27
    | CRC32CW = 28
    | CRC32H = 29
    | CRC32W = 30
    | DBG = 31
    | DMB = 32
    | DSB = 33
    | EOR = 34
    | VMOV = 35
    | FLDMDBX = 36
    | FLDMIAX = 37
    | VMRS = 38
    | FSTMDBX = 39
    | FSTMIAX = 40
    | HINT = 41
    | HLT = 42
    | ISB = 43
    | LDA = 44
    | LDAB = 45
    | LDAEX = 46
    | LDAEXB = 47
    | LDAEXD = 48
    | LDAEXH = 49
    | LDAH = 50
    | LDC2L = 51
    | LDC2 = 52
    | LDCL = 53
    | LDC = 54
    | LDMDA = 55
    | LDMDB = 56
    | LDM = 57
    | LDMIB = 58
    | LDRBT = 59
    | LDRB = 60
    | LDRD = 61
    | LDREX = 62
    | LDREXB = 63
    | LDREXD = 64
    | LDREXH = 65
    | LDRH = 66
    | LDRHT = 67
    | LDRSB = 68
    | LDRSBT = 69
    | LDRSH = 70
    | LDRSHT = 71
    | LDRT = 72
    | LDR = 73
    | MCR = 74
    | MCR2 = 75
    | MCRR = 76
    | MCRR2 = 77
    | MLA = 78
    | MLS = 79
    | MOV = 80
    | MOVT = 81
    | MOVW = 82
    | MRC = 83
    | MRC2 = 84
    | MRRC = 85
    | MRRC2 = 86
    | MRS = 87
    | MSR = 88
    | MUL = 89
    | MVN = 90
    | ORR = 91
    | PKHBT = 92
    | PKHTB = 93
    | PLDW = 94
    | PLD = 95
    | PLI = 96
    | QADD = 97
    | QADD16 = 98
    | QADD8 = 99
    | QASX = 100
    | QDADD = 101
    | QDSUB = 102
    | QSAX = 103
    | QSUB = 104
    | QSUB16 = 105
    | QSUB8 = 106
    | RBIT = 107
    | REV = 108
    | REV16 = 109
    | REVSH = 110
    | RFEDA = 111
    | RFEDB = 112
    | RFEIA = 113
    | RFEIB = 114
    | RSB = 115
    | RSC = 116
    | SADD16 = 117
    | SADD8 = 118
    | SASX = 119
    | SBC = 120
    | SBFX = 121
    | SDIV = 122
    | SEL = 123
    | SETEND = 124
    | SHA1C_32 = 125
    | SHA1H_32 = 126
    | SHA1M_32 = 127
    | SHA1P_32 = 128
    | SHA1SU0_32 = 129
    | SHA1SU1_32 = 130
    | SHA256H_32 = 131
    | SHA256H2_32 = 132
    | SHA256SU0_32 = 133
    | SHA256SU1_32 = 134
    | SHADD16 = 135
    | SHADD8 = 136
    | SHASX = 137
    | SHSAX = 138
    | SHSUB16 = 139
    | SHSUB8 = 140
    | SMC = 141
    | SMLABB = 142
    | SMLABT = 143
    | SMLAD = 144
    | SMLADX = 145
    | SMLAL = 146
    | SMLALBB = 147
    | SMLALBT = 148
    | SMLALD = 149
    | SMLALDX = 150
    | SMLALTB = 151
    | SMLALTT = 152
    | SMLATB = 153
    | SMLATT = 154
    | SMLAWB = 155
    | SMLAWT = 156
    | SMLSD = 157
    | SMLSDX = 158
    | SMLSLD = 159
    | SMLSLDX = 160
    | SMMLA = 161
    | SMMLAR = 162
    | SMMLS = 163
    | SMMLSR = 164
    | SMMUL = 165
    | SMMULR = 166
    | SMUAD = 167
    | SMUADX = 168
    | SMULBB = 169
    | SMULBT = 170
    | SMULL = 171
    | SMULTB = 172
    | SMULTT = 173
    | SMULWB = 174
    | SMULWT = 175
    | SMUSD = 176
    | SMUSDX = 177
    | SRSDA = 178
    | SRSDB = 179
    | SRSIA = 180
    | SRSIB = 181
    | SSAT = 182
    | SSAT16 = 183
    | SSAX = 184
    | SSUB16 = 185
    | SSUB8 = 186
    | STC2L = 187
    | STC2 = 188
    | STCL = 189
    | STC = 190
    | STL = 191
    | STLB = 192
    | STLEX = 193
    | STLEXB = 194
    | STLEXD = 195
    | STLEXH = 196
    | STLH = 197
    | STMDA = 198
    | STMDB = 199
    | STM = 200
    | STMIB = 201
    | STRBT = 202
    | STRB = 203
    | STRD = 204
    | STREX = 205
    | STREXB = 206
    | STREXD = 207
    | STREXH = 208
    | STRH = 209
    | STRHT = 210
    | STRT = 211
    | STR = 212
    | SUB = 213
    | SVC = 214
    | SWP = 215
    | SWPB = 216
    | SXTAB = 217
    | SXTAB16 = 218
    | SXTAH = 219
    | SXTB = 220
    | SXTB16 = 221
    | SXTH = 222
    | TEQ = 223
    | TRAP = 224
    | TST = 225
    | UADD16 = 226
    | UADD8 = 227
    | UASX = 228
    | UBFX = 229
    | UDIV = 230
    | UHADD16 = 231
    | UHADD8 = 232
    | UHASX = 233
    | UHSAX = 234
    | UHSUB16 = 235
    | UHSUB8 = 236
    | UMAAL = 237
    | UMLAL = 238
    | UMULL = 239
    | UQADD16 = 240
    | UQADD8 = 241
    | UQASX = 242
    | UQSAX = 243
    | UQSUB16 = 244
    | UQSUB8 = 245
    | USAD8 = 246
    | USADA8 = 247
    | USAT = 248
    | USAT16 = 249
    | USAX = 250
    | USUB16 = 251
    | USUB8 = 252
    | UXTAB = 253
    | UXTAB16 = 254
    | UXTAH = 255
    | UXTB = 256
    | UXTB16 = 257
    | UXTH = 258
    | VABAL = 259
    | VABA = 260
    | VABDL = 261
    | VABD = 262
    | VABS = 263
    | VACGE = 264
    | VACGT = 265
    | VADD = 266
    | VADDHN = 267
    | VADDL = 268
    | VADDW = 269
    | VAND = 270
    | VBIC = 271
    | VBIF = 272
    | VBIT = 273
    | VBSL = 274
    | VCEQ = 275
    | VCGE = 276
    | VCGT = 277
    | VCLE = 278
    | VCLS = 279
    | VCLT = 280
    | VCLZ = 281
    | VCMP = 282
    | VCMPE = 283
    | VCNT = 284
    | VCVTA_S32_F32 = 285
    | VCVTA_U32_F32 = 286
    | VCVTA_S32_F64 = 287
    | VCVTA_U32_F64 = 288
    | VCVTB = 289
    | VCVT = 290
    | VCVTM_S32_F32 = 291
    | VCVTM_U32_F32 = 292
    | VCVTM_S32_F64 = 293
    | VCVTM_U32_F64 = 294
    | VCVTN_S32_F32 = 295
    | VCVTN_U32_F32 = 296
    | VCVTN_S32_F64 = 297
    | VCVTN_U32_F64 = 298
    | VCVTP_S32_F32 = 299
    | VCVTP_U32_F32 = 300
    | VCVTP_S32_F64 = 301
    | VCVTP_U32_F64 = 302
    | VCVTT = 303
    | VDIV = 304
    | VDUP = 305
    | VEOR = 306
    | VEXT = 307
    | VFMA = 308
    | VFMS = 309
    | VFNMA = 310
    | VFNMS = 311
    | VHADD = 312
    | VHSUB = 313
    | VLD1 = 314
    | VLD2 = 315
    | VLD3 = 316
    | VLD4 = 317
    | VLDMDB = 318
    | VLDMIA = 319
    | VLDR = 320
    | VMAXNM_F64 = 321
    | VMAXNM_F32 = 322
    | VMAX = 323
    | VMINNM_F64 = 324
    | VMINNM_F32 = 325
    | VMIN = 326
    | VMLA = 327
    | VMLAL = 328
    | VMLS = 329
    | VMLSL = 330
    | VMOVL = 331
    | VMOVN = 332
    | VMSR = 333
    | VMUL = 334
    | VMULL_P64 = 335
    | VMULL = 336
    | VMVN = 337
    | VNEG = 338
    | VNMLA = 339
    | VNMLS = 340
    | VNMUL = 341
    | VORN = 342
    | VORR = 343
    | VPADAL = 344
    | VPADDL = 345
    | VPADD = 346
    | VPMAX = 347
    | VPMIN = 348
    | VQABS = 349
    | VQADD = 350
    | VQDMLAL = 351
    | VQDMLSL = 352
    | VQDMULH = 353
    | VQDMULL = 354
    | VQMOVUN = 355
    | VQMOVN = 356
    | VQNEG = 357
    | VQRDMULH = 358
    | VQRSHL = 359
    | VQRSHRN = 360
    | VQRSHRUN = 361
    | VQSHL = 362
    | VQSHLU = 363
    | VQSHRN = 364
    | VQSHRUN = 365
    | VQSUB = 366
    | VRADDHN = 367
    | VRECPE = 368
    | VRECPS = 369
    | VREV16 = 370
    | VREV32 = 371
    | VREV64 = 372
    | VRHADD = 373
    | VRINTA_F64 = 374
    | VRINTA_F32 = 375
    | VRINTM_F64 = 376
    | VRINTM_F32 = 377
    | VRINTN_F64 = 378
    | VRINTN_F32 = 379
    | VRINTP_F64 = 380
    | VRINTP_F32 = 381
    | VRINTR = 382
    | VRINTX = 383
    | VRINTX_F32 = 384
    | VRINTZ = 385
    | VRINTZ_F32 = 386
    | VRSHL = 387
    | VRSHRN = 388
    | VRSHR = 389
    | VRSQRTE = 390
    | VRSQRTS = 391
    | VRSRA = 392
    | VRSUBHN = 393
    | VSELEQ_F64 = 394
    | VSELEQ_F32 = 395
    | VSELGE_F64 = 396
    | VSELGE_F32 = 397
    | VSELGT_F64 = 398
    | VSELGT_F32 = 399
    | VSELVS_F64 = 400
    | VSELVS_F32 = 401
    | VSHLL = 402
    | VSHL = 403
    | VSHRN = 404
    | VSHR = 405
    | VSLI = 406
    | VSQRT = 407
    | VSRA = 408
    | VSRI = 409
    | VST1 = 410
    | VST2 = 411
    | VST3 = 412
    | VST4 = 413
    | VSTMDB = 414
    | VSTMIA = 415
    | VSTR = 416
    | VSUB = 417
    | VSUBHN = 418
    | VSUBL = 419
    | VSUBW = 420
    | VSWP = 421
    | VTBL = 422
    | VTBX = 423
    | VCVTR = 424
    | VTRN = 425
    | VTST = 426
    | VUZP = 427
    | VZIP = 428
    | ADDW = 429
    | ADR_W = 430
    | ASR = 431
    | DCPS1 = 432
    | DCPS2 = 433
    | DCPS3 = 434
    | IT = 435
    | LSL = 436
    | LSR = 437
    | ORN = 438
    | ROR = 439
    | RRX = 440
    | SUBW = 441
    | TBB = 442
    | TBH = 443
    | CBNZ = 444
    | CBZ = 445
    | NOP = 446
    | POP = 447
    | PUSH = 448
    | SEV = 449
    | SEVL = 450
    | WFE = 451
    | WFI = 452
    | YIELD = 453